using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoLooper.Models
{
    public class PostCollector
    {
        public Post Post { get; set; }
        public List<Comment> Comments { get; set; } 
    }
}
