using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Salon.Util
{
    public static class InputSanitizer
    {
        public static string Name(string input) =>
       string.IsNullOrWhiteSpace(input) ? string.Empty
       : Regex.Replace(input.Trim(), @"\s+", " ");

        public static string Email(string input) =>
            string.IsNullOrWhiteSpace(input) ? string.Empty
            : input.Trim().ToLower();

        public static string Phone(string input) =>
            string.IsNullOrWhiteSpace(input) ? string.Empty
            : Regex.Replace(input, @"[^\d]", "");

        public static string Address(string input) =>
            string.IsNullOrWhiteSpace(input) ? string.Empty
            : Regex.Replace(input.Trim(), @"\s+", " ");

        public static string Username(string input) =>
            string.IsNullOrWhiteSpace(input) ? string.Empty
            : Regex.Replace(input.Trim().ToLower(), @"[^a-z0-9_]", "");

        public static string Password(string input) =>
            string.IsNullOrWhiteSpace(input) ? string.Empty
            : input.Trim();

        public static string General(string input) =>
            string.IsNullOrWhiteSpace(input) ? string.Empty
            : input.Trim();
    }
}
