using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoLooper.Services
{
    public interface IEmailService
    {
        public Task SendEmailAsync(string email, string subject, string message, IConfiguration config);
    }
}
