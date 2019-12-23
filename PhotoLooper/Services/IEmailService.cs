using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoLooper.Services
{
    public interface IEmailService
    {
        public Task SendEmailAsync(IConfiguration config, string email, string title,
                    string subject, string message, string path = null, string type = null, string subType = null);   
    }
}
