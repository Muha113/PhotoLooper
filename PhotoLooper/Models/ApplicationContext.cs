using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PhotoLooper.Models
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<UserLocal> UsersLocal { get; set; }
        public DbSet<Follower> Followers { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public void CreatePost(Post post)
        {
            Posts.Add(post);
            SaveChanges();
        }

        public List<PostCollector> GetPostsCollector(int id)
        {
            Post[] posts = Posts.Where(p => p.UserId == id).ToArray();
            List<PostCollector> resPosts = new List<PostCollector>();
            for (int i = 0; i < posts.Length; i++)
            {
                PostCollector pst = new PostCollector
                {
                    Post = posts[i],
                    Comments = Comments.Where(x => x.PostId == posts[i].Id).ToList(),
                };
                resPosts.Add(pst);
            }
            return resPosts;
        }

        public int GenerateToken(string email)
        {
            int res = 0;
            for(int i = 0; i < email.Length; i++)
            {
                res += email[i];
            }
            return res;
        }

        public void AddFollower(int flr, int flw)
        {
            Follower res = new Follower
            {
                FollowerId = flr,
                FollowingId = flw,
            };
            Followers.Add(res);
            SaveChanges();
        }

        public List<Follower> GetFollowers(int id)
        {
            List<Follower> resFollowers = Followers.Where(p => p.FollowerId == id).ToList();
            return resFollowers;
        }

        public List<Follower> GetFollowings(int id)
        {
            List<Follower> resFollowings = Followers.Where(p => p.FollowingId == id).ToList();
            return resFollowings;
        }

        public UserCollector FindUser(string nickname)
        {
            UserLocal[] userLocal = UsersLocal.Where(p => p.NickName == nickname).ToArray();
            if (userLocal.Length == 0)
            {
                UserCollector res = new UserCollector
                {
                    User = userLocal[0],
                    Posts = GetPostsCollector(userLocal[0].Id),
                    Followers = GetFollowers(userLocal[0].Id),
                    Following = GetFollowings(userLocal[0].Id),
                };
                return res;
            }
            return null;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
            SaveChanges();
        }

        public void CreateUserLocal(UserLocal userLocal)
        {
            UsersLocal.Add(userLocal);
            SaveChanges();
        }

        public void UpdateUser(User user)
        {
            Users.Update(user);
            SaveChanges();
        }

        public UserCollector GetUserCollector(int id)
        {
            UserCollector resultUser = new UserCollector
            {
                User = UsersLocal.Where(p => p.UserId == id).ToArray()[0],
                Posts = GetPostsCollector(id),
                Followers = GetFollowers(id),
                Following = GetFollowings(id),
            };
            return resultUser;
        }
    }
}
