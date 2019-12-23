using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace PhotoLooper.Services
{
    public class EmailService : IEmailService
    {
        //private readonly IConfiguration _config;

        /*public EmailService(IConfiguration config)
        {
            _config = config;
        }*/

        public async Task SendEmailAsync(IConfiguration config, string email, string title, 
            string subject, string message, string path = null, string type = null, string subType=null)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress(title, config["emailhost:email"]));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            var multipart = new Multipart("mixed");
            var body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };
            multipart.Add(body);
            if (path == null)
            {
                var attachment = new MimePart(type, subType)
                {
                    Content = new MimeContent(File.OpenRead(path)),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = Path.GetFileName(path)
                };
                multipart.Add(attachment);
            }
            emailMessage.Body = multipart;
            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(config["host:webhost"], int.Parse(config["host:port"]), bool.Parse(config["host:useSsl"]));
                await client.AuthenticateAsync(config["emailhost:email"], config["emailhost:password"]);
                //await client.AuthenticateAsync()
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
    }
}
