using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoLooper.Models
{
    public static class StaticUser
    {
        public static int Id { get; set; }
        public static int CurrentPostId { get; set; }
        public static int CurrentCommentId { get; set; }
    }
}
