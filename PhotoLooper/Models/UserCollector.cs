using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoLooper.Models
{
    public class UserCollector
    {
        public SocialUser User { get; set; }
        public List<Follower> Followers { get; set; }
        public List<Follower> Following { get; set; }
        public List<PostCollector> Posts { get; set; }
    }
}
