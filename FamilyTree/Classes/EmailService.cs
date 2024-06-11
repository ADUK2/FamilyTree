using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Classes
{
    public class EmailService
    {
        private string smtpServer = "smtp.example.com";
        private int smtpPort = 587;
        private string smtpUser = "your-email@example.com";
        private string smtpPass = "your-email-password";

        public void SendVerificationCode(string toEmail, string code)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(smtpServer);

                mail.From = new MailAddress(smtpUser);
                mail.To.Add(toEmail);
                mail.Subject = "Password Reset Verification Code";
                mail.Body = $"Your verification code is: {code}";

                SmtpServer.Port = smtpPort;
                SmtpServer.Credentials = new NetworkCredential(smtpUser, smtpPass);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in SendVerificationCode(): {0}", ex.ToString());
            }
        }
    }
}
