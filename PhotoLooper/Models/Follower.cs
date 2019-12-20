using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoLooper.Models
{
    public class Follower
    {
        public int Id { get; set; }
        public string FollowerId { get; set; }
        public string FollowingId { get; set; }
    }
}
