using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoLooper.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Path { get; set; }
        public DateTime DateTime { get; set; }
    }
}
