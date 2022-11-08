using System.Net.Mail;
using Norbs.Common;

namespace Norbs.Core.Services
{
    public class EmailService
    {
        private EmailService()
        {
        }

        public static void SendEmail(string fromAddress, string subject, string body)
        {
            var message = new MailMessage(fromAddress, AppSettings.Get<string>("FormSubmitEmailAddress"))
            {
                Subject = subject,
                Body = body
            };

            using (var client = new SmtpClient())
            {
                client.Send(message);
            }
        }
    }
}