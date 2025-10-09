using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Salon.Util
{
    public static class SmsSender
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task SendSmsNotificationAsync(string phone, string customerName, string appointmentDate, string startTime)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(Encoding.ASCII.GetBytes("sms:XOqT5cBC")));

                var message = $"Hi {customerName}, your appointment is confirmed on {appointmentDate} at {startTime}. Please arrive 10 minutes early.";

                var payload = new
                {
                    textMessage = new { text = message },
                    phoneNumbers = new[] { phone }
                };

                var content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");

                var response = await client.PostAsync("http://192.168.100.31:8080/message", content);

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("SMS notification failed to send.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


    }
}
