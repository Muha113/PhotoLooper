using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using MimeKit;
using MimeKit.Text;
using PhotoLooper.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
//using System.Net.Mail;
using MailKit.Net.Smtp;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace PhotoLooper.BackgroundServices
{
    public class SendStatsBackgroundService : BackgroundService
    {
        private IEmailService _emailService;
        private IConfiguration _config;
        public SendStatsBackgroundService(IEmailService emailService, IConfiguration config)
        {
            _emailService = emailService;
            _config = config;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (true)
            {
                Console.WriteLine("hi");
                await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);

                var emailMessage = new MimeMessage();

                emailMessage.From.Add(new MailboxAddress("", "dan4kmuha113@yandex.ru"));
                emailMessage.To.Add(new MailboxAddress("", "daniilmukha@tut.by"));
                emailMessage.Subject = "Administrator";
                var body = new TextPart(MimeKit.Text.TextFormat.Html)
                {
                    Text = "logs for last 2 days)"
                };
                var attachment = new MimePart("text", "txt")
                {
                    Content = new MimeContent(File.OpenRead("logs.txt")),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = Path.GetFileName("logs.txt")
                };
                var multipart = new Multipart("mixed");
                multipart.Add(body);
                multipart.Add(attachment);
                emailMessage.Body = multipart;

                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync("smtp.yandex.ru", 25, false);
                    await client.AuthenticateAsync("dan4kmuha113@yandex.ru", "5oB26eTCxZ");
                    //await client.AuthenticateAsync()
                    await client.SendAsync(emailMessage);
                    await client.DisconnectAsync(true);
                }
                Console.WriteLine("Message sent");
            }
        }
    }
}
