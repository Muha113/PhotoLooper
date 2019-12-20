using Microsoft.AspNetCore.Identity;
using System;

namespace PhotoLooper.Models
{
    public class SocialUser : IdentityUser
    {
        public bool IsPostSavedLocal { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Born { get; set; }
        public string NickName { get; set; }
        public string Description { get; set; }
        public string AvatarPath { get; set; }
    }
}
