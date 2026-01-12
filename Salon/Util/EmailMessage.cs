using Mysqlx.Crud;
using Salon.Controller;
using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;


namespace Salon.Util
{
    public static class EmailMessage
    {
        public static OwnderEmailRepository owner_repo = new OwnderEmailRepository();
        public static OwnerEmailController owner_controller;
      
        public static string GenerateOtp()
        {
            var random = new Random();
            return random.Next(100000, 999999).ToString(); 
        }
        public static async Task SendEmailAsync(string to, string subject, string body)
    {
        using (var smtp = new SmtpClient("smtp.gmail.com", 587))
        {
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("", "");

            var mail = new MailMessage("", to, subject, body);
            await smtp.SendMailAsync(mail); 
        }
    }
        public static async Task SendNotificationEmailAsync(string to, string recipientName, string appointmentTime, string services, string customMessage)
        {
            string subject = "🔔 Appointment Notification"; 

            string body = $@"
    <html>
    <head>
      <style>
        body {{ font-family: Arial, sans-serif; background-color: #f4f4f4; padding: 20px; }}
        .container {{ background-color: #ffffff; padding: 20px; border-radius: 8px; box-shadow: 0 2px 5px rgba(0,0,0,0.1); }}
        .header {{ font-size: 18px; font-weight: bold; color: #333333; margin-bottom: 10px; }}
        .message {{ font-size: 14px; color: #555555; margin-bottom: 20px; }}
        .footer {{ font-size: 12px; color: #999999; border-top: 1px solid #eeeeee; padding-top: 10px; }}
      </style>
    </head>
    <body>
      <div class='container'>
        <div class='header'>🔔 Appointment Notification</div>
        <div class='message'>
          Dear {recipientName},<br><br>
          {customMessage}<br><br>
          <strong>Scheduled Time:</strong> {appointmentTime}<br><br>
          <strong>Services:</strong> {services}<br><br>
          Thank you!
        </div>
        <div class='footer'>
          This is an automated message. Please do not reply.<br>
          &copy; 2025 HCSANSOR
        </div>
      </div>
    </body>
    </html>";

            using (var smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("", "");

                var mail = new MailMessage("", to, subject, body)
                {
                    IsBodyHtml = true
                };

                await smtp.SendMailAsync(mail);
            }
        }
        public static async Task<bool> SendTestEmailConnection(string user_email, string user_password, string shop_name)
        {
            try
            {
                using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(user_email, user_password);

                    var mail = new MailMessage() 
                    {
                        From = new MailAddress(user_email, shop_name),
                        Subject = "SMTP Test",
                        Body = "This is  a test connection message.",
                        IsBodyHtml = true
                    };
                    mail.To.Add(user_email);
                    await smtp.SendMailAsync (mail);
                    return true;

                }

            }
            catch (SmtpException smtpEx)
            {
                Console.WriteLine($"SMTP error: {smtpEx.StatusCode} - {smtpEx}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General  error: {ex}");
                return false;
            }
        }
        public static async Task<bool> SendEmailNotifDiscount(string to, string subject, string body)
        {
              owner_controller = new OwnerEmailController(owner_repo);
              var owner = owner_controller.GetOwnerEmail();
            try
            {
                using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(owner.email, owner.pass);

                    var mail = new MailMessage();
                    mail.From = new MailAddress(owner.email, owner.shop_name);
                    mail.To.Add(to);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true;


                    await smtp.SendMailAsync(mail);
                    return true;

                }

            }
            catch (SmtpException smtpEx) 
            { 
                Console.WriteLine($"SMTP error: {smtpEx.StatusCode} - {smtpEx}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General  error: {ex}");
                return false;
            }
        }

       
        public static async Task EmailOTPNotification(string to, string recipientName, string otp)
        {
            string subject = "Your OTP Code";

            string body = $@"
            <html>
            <head>
              <style>
                body {{ font-family: Arial; background-color: #f4f4f4; padding: 20px; }}
                .container {{ background-color: #fff; padding: 20px; border-radius: 8px; }}
                .header {{ font-size: 18px; font-weight: bold; color: #333; }}
                .otp {{ font-size: 24px; font-weight: bold; color: #007BFF; }}
                .footer {{ font-size: 12px; color: #999; margin-top: 20px; }}
              </style>
            </head>
            <body>
              <div class='container'>
                <div class='header'>🔐 Forgot Password OTP</div>
                <p>Hello {recipientName},</p>
                <p>Use the following code to reset your password:</p>
                <p class='otp'>{otp}</p>
                <p>This code will expire in 5 minutes.</p>
                <div class='footer'>
                  This is an automated message. Please do not reply.<br>
                  &copy; 2025 HCSANSOR
                </div>
              </div>
            </body>
            </html>";

            using (var smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("", "");

                var mail = new MailMessage("", to, subject, body)
                {
                    IsBodyHtml = true
                };

                await smtp.SendMailAsync(mail);
            }
        }

    }
}
