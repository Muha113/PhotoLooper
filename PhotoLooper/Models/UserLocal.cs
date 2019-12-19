using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoLooper.Models
{
    public class UserLocal
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool IsPostSavedLocal { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Born { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string AvatarPath { get; set; }
    }
}
