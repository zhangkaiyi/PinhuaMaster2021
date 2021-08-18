using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PinhuaMaster.Services
{
    // This class is used by the application to send email for account confirmation and password reset.
    // For more details see https://go.microsoft.com/fwlink/?LinkID=532713
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            using (var client = new System.Net.Mail.SmtpClient())
            {
                client.Host = "smtp.qq.com";
                client.UseDefaultCredentials = true;
                client.EnableSsl = true;
                client.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                client.Credentials = new System.Net.NetworkCredential("116307766@qq.com", "ojvtppnbkmuabjae");

                var Message = new System.Net.Mail.MailMessage("116307766@qq.com", email);
                Message.Subject = subject;
                Message.Body = message;
                Message.SubjectEncoding = System.Text.Encoding.UTF8;
                Message.BodyEncoding = System.Text.Encoding.UTF8;
                Message.Priority = System.Net.Mail.MailPriority.High;
                Message.IsBodyHtml = true;

                client.Send(Message);
            }
            return Task.CompletedTask;
        }
    }
}
