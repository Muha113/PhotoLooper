﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;


namespace PhotoLooper.Services
{
    public class EmailService : IEmailService
    {
        //private readonly IConfiguration _config;

        /*public EmailService(IConfiguration config)
        {
            _config = config;
        }*/

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("ПроверОЧКА работоспособности моего костыля", "dan4kmuha113@yandex.ru"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.yandex.ru", 25, false);
                await client.AuthenticateAsync("dan4kmuha113@yandex.ru", "5oB26eTCxZ");
                //await client.AuthenticateAsync()
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
    }
}
