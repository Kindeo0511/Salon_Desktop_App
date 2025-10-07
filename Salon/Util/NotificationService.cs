using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Util
{
    public static class NotificationService
    {
        private const string EmailSender = "alexprada782@gmail.com";
        private const string EmailPassword = "xewo quer qlch cmzv";
        private const string SmsApiKey = "textbelt"; // Replace with your paid key if needed

        public static async Task SendNotificationAsync(string toEmail, string toPhone, string recipientName, string appointmentTime, string customMessage)
        {
            bool emailSent = await TrySendEmailAsync(toEmail, recipientName, appointmentTime, customMessage);

            if (!emailSent)
            {
                await TrySendSmsFallbackAsync(toPhone, recipientName, appointmentTime, customMessage);
            }
        }

        private static async Task<bool> TrySendEmailAsync(string to, string name, string time, string message)
        {
            string subject = "🔔 Appointment Notification";
            string body = $@"
        <html>
        <head>
          <style>
            body {{ font-family: Arial; background-color: #f4f4f4; padding: 20px; }}
            .container {{ background-color: #fff; padding: 20px; border-radius: 8px; box-shadow: 0 2px 5px rgba(0,0,0,0.1); }}
            .header {{ font-size: 18px; font-weight: bold; color: #333; margin-bottom: 10px; }}
            .message {{ font-size: 14px; color: #555; margin-bottom: 20px; }}
            .footer {{ font-size: 12px; color: #999; border-top: 1px solid #eee; padding-top: 10px; }}
          </style>
        </head>
        <body>
          <div class='container'>
            <div class='header'>🔔 Appointment Notification</div>
            <div class='message'>
              Dear {name},<br><br>
              {message}<br><br>
              <strong>Scheduled Time:</strong> {time}<br><br>
              Thank you!
            </div>
            <div class='footer'>
              This is an automated message. Please do not reply.<br>
              &copy; 2025 AlexPrada Systems
            </div>
          </div>
        </body>
        </html>";

            try
            {
                using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential(EmailSender, EmailPassword);

                    var mail = new MailMessage(EmailSender, to, subject, body)
                    {
                        IsBodyHtml = true
                    };

                    await smtp.SendMailAsync(mail);
                    Log("Email sent successfully to " + to);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Log("Email failed: " + ex.Message);
                return false;
            }
        }
        private static string NormalizePhone(string phone)
        {
            if (phone.StartsWith("0"))
                return "+63" + phone.Substring(1);
            return phone;
        }


        private static async Task TrySendSmsFallbackAsync(string phone, string name, string time, string message)
        {
            var smsMessage = $"Hi {name}, your appointment is confirmed for {time}. {message}";
            var normalizedPhone = NormalizePhone(phone);

            try
            {
                await SMSAPI.SendSemaphoreSmsAsync(normalizedPhone, smsMessage);
                Log("SMS sent via Semaphore to " + normalizedPhone);
            }
            catch (Exception ex)
            {
                Log("Semaphore SMS failed: " + ex.Message);
            }
        }


        private static void Log(string message)
        {
            // Replace with your audit-safe logging system
            Console.WriteLine($"[{DateTime.Now}] {message}");
        }
    }
}
