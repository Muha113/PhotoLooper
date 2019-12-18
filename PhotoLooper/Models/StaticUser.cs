using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PhotoLooper.Models
{
    public static class StaticUser
    {
        private static int GenerateToken(string email)
        {
            int res = 0;
            for (int i = 0; i < email.Length; i++)
            {
                res += email[i];
            }
            return res;
        }

        public static int GetUserId(string email)
        {
            return GenerateToken(email);
        }
    }
}
