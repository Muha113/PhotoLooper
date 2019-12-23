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

                await _emailService.SendEmailAsync(_config, _config["background:email"], _config["background:title"], 
                    _config["background:subject"], _config["background:message"],
                    _config["background:path"], _config["background:type"], _config["background:subtype"]);

                Console.WriteLine("Message sent");
            }
        }
    }
}
