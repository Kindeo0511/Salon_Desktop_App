using MySqlX.XDevAPI;
using Newtonsoft.Json;
using Salon.Controller;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.Util
{
    public static class SmsSender
    {
        private static readonly HttpClient client = new HttpClient();
        // 🔔 Appointment notification
        public static async Task SendSmsNotificationAsync(string phone, string customerName, string appointmentDate, string startTime)
        {
            string message = $"Hi {customerName}, your appointment is confirmed on {appointmentDate} at {startTime}. Please arrive 10 minutes early.";
            await SendSmsAsync(phone, message);
        }
        public static async Task SendDiscountNotifSMS(int customerId, string message)
        {
            var repo = new CustomerRepository();
            var controller = new CustomerController(repo);
            var customer = controller.GetCustomerById(customerId);
            var to = customer.phoneNumber;

            string smsMessage = $"Hi! {customer.firstName}, {message}";

            await SendSmsAsync(to, smsMessage);
        }

        // 🔐 OTP delivery
        public static async Task SendOtpAsync(string phone, string recipientName, string otp)
        {
            string message = $"Hi {recipientName}, your OTP code is {otp}. It will expire in 5 minutes.";
            await SendSmsAsync(phone, message);
        }

        // 📤 Core SMS sender
        private static async Task SendSmsAsync(string phone, string message)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(Encoding.ASCII.GetBytes("sms:XOqT5cBC")));

                var payload = new
                {
                    textMessage = new { text = message },
                    phoneNumbers = new[] { phone }
                };

                var content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");

                var response = await client.PostAsync("http://100.104.201.251:8080/message", content);

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("SMS failed to send.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //public static async Task SendSmsNotificationAsync(string phone, string customerName, string appointmentDate, string startTime)
        //{
        //    using (var client = new HttpClient())
        //    {
        //        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
        //            Convert.ToBase64String(Encoding.ASCII.GetBytes("sms:XOqT5cBC")));

        //        var message = $"Hi {customerName}, your appointment is confirmed on {appointmentDate} at {startTime}. Please arrive 10 minutes early.";

        //        var payload = new
        //        {
        //            textMessage = new { text = message },
        //            phoneNumbers = new[] { phone }
        //        };

        //        var content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");

        //        var response = await client.PostAsync("http://10.138.81.240:8080/message", content);

        //        if (!response.IsSuccessStatusCode)
        //        {
        //            MessageBox.Show("SMS notification failed to send.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //    }
        //}


    }
}
