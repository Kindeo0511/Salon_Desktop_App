using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Util
{
    public static class SMSAPI
    {
        public static async Task SendSemaphoreSmsAsync(string phone, string message)
        {
            using (var client = new HttpClient())
            {
                var values = new Dictionary<string, string>
        {
            { "apikey", "ff7a33871499dc9ac8e831c87da29b3f" },
            { "number", phone },
            { "message", message },
            { "sendername", "HCSANSOR" } // Optional: customize sender name
        };

                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync("https://api.semaphore.co/api/v4/messages", content);
                var result = await response.Content.ReadAsStringAsync();

                Console.WriteLine($"[SMS] Semaphore response: {result}");
            }
        }
    }
}
