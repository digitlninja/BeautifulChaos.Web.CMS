using System;
using System.Net;
using System.Threading.Tasks;
using CMS.Models;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MimeKit;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace CMS.Services
{
    public interface IMailService
    {
        ConfigSettings Settings { get; }
        Task<RegisterViewModel> SendEmailAsync(string email, string subject, string message);
        Task<Response> Execute(string apiKey, string email, string subject, string message);
    }

    public class MailService : IMailService
    {
        public ConfigSettings Settings { get; set; }
        public string FromAddress { get; set; }
        public string FromTitle { get; set; }
        public string SmtpServer { get; set; }
        public int SmtpPort { get; set; }

        public MailService(IOptionsSnapshot<ConfigSettings> settings)
        {
            this.Settings = settings.Value;
            this.FromAddress = "williamlangroudi@gmail.com";
            this.FromTitle = "Beautiful Chaos";
            this.SmtpServer = "smtp.gmail.com";
            this.SmtpPort = 587;
        }

        public async Task<RegisterViewModel> SendEmailAsync(string email, string subject, string message)
        {
            var model = new RegisterViewModel();
            if (email == null)
            {
                model.Succeeded = false;
                return model;
            }

            if (subject == null)
            {
                model.Succeeded = false;
                return model;
            }

            if (message == null)
            {
                model.Succeeded = false;
                return model;
            }
                
            var client = new SendGridClient(Settings.SendGridKey);

            var from = new EmailAddress(this.FromAddress, this.FromTitle);
            var to = new EmailAddress(email, "Example User");

            var msg = MailHelper.CreateSingleEmail(from, to, subject, null, message);
            var response = await client.SendEmailAsync(msg);

            if (response.StatusCode == HttpStatusCode.Accepted || response.StatusCode == HttpStatusCode.OK)
            {
                model.Succeeded = true;
                return model;
            }

            model.Succeeded = false;
            return model;
        }

        public Task<Response> Execute(string apiKey, string email, string subject, string message)
        {
            var mailClient = new SendGridClient(apiKey);

            var msg = new SendGridMessage()
            {
                From = new EmailAddress("williamlangroudi@gmail.com", "Beautiful Chaos"),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };

            msg.AddTo(new EmailAddress(email));

            return mailClient.SendEmailAsync(msg);
        }

        public MimeMessage CreateMimeMessage(string email, string subject, string message)
        {
            var toAddress = email;
            var bodyContent = message;

            var mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress(this.FromTitle, this.FromAddress));
            mimeMessage.To.Add(new MailboxAddress(toAddress));
            mimeMessage.Subject = subject;
            mimeMessage.Body = new TextPart("plain")
            {
                Text = bodyContent
            };

            return mimeMessage;
        }
    }
}
