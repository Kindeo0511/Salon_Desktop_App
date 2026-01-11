using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Dapper;

public class DatabaseHelper
{
    private readonly string _connectionString;
    private readonly string _mysqlBinPath;

    public DatabaseHelper(string connectionString, string mysqlBinPath)
    {
        _connectionString = connectionString;
        _mysqlBinPath = mysqlBinPath; // e.g. @"C:\Program Files\MySQL\MySQL Server 8.0\bin\"
    }

    public void BackupDatabase(string backupPath)
    {
        var builder = new MySqlConnectionStringBuilder(_connectionString);

        string user = builder.UserID;
        string password = builder.Password;
        string database = builder.Database;

        string dumpExe = Path.Combine(_mysqlBinPath, "mysqldump.exe");

        if (!File.Exists(dumpExe))
            throw new FileNotFoundException("mysqldump.exe not found at: " + dumpExe);

        // Build arguments safely
        string args = string.IsNullOrEmpty(password)
            ? $"-u {user} --routines --triggers --events {database}"
            : $"-u {user} -p{password} --routines --triggers --events {database}";

        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = dumpExe,
            Arguments = args,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using (Process process = Process.Start(psi))
        {
            string result = process.StandardOutput.ReadToEnd();
            string errors = process.StandardError.ReadToEnd();

            File.WriteAllText(backupPath, result);

            if (!string.IsNullOrWhiteSpace(errors))
            {
                throw new Exception("mysqldump error: " + errors);
            }

            if (new FileInfo(backupPath).Length < 100)
            {
                throw new Exception("Backup file is suspiciously small. Check database name or permissions.");
            }
        }
    }


    public void RestoreDatabase(string backupPath)
    {
        var builder = new MySqlConnectionStringBuilder(_connectionString);

        string user = builder.UserID;
        string password = builder.Password;
        string database = builder.Database;

        string mysqlExe = Path.Combine(_mysqlBinPath, "mysql.exe");

        string args = string.IsNullOrEmpty(password) ? $"-u {user} {database}" : $"-u {user} -p{password} {database}";

        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = mysqlExe,
            Arguments = args,
            RedirectStandardInput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using (Process process = Process.Start(psi))
        using (StreamWriter writer = process.StandardInput)
        {
            string sql = File.ReadAllText(backupPath);
            writer.WriteLine(sql);
        }
    }

    // Example Dapper query
    public int GetClientCount()
    {
        using (var conn = new MySqlConnection(_connectionString))
        {
            return conn.ExecuteScalar<int>("SELECT COUNT(*) FROM clients;");
        }
    }
}
