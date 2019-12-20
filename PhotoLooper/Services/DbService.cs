using PhotoLooper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoLooper.Services
{
    public class DbService : IDbService
    {
        public ApplicationContext _context;
        public DbService(ApplicationContext context)
        {
            _context = context;
        }

        public void CreatePost(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
        }

        public int GetPostsAmount(string id)
        {
            return _context.Posts.Where(p => p.UserId == id).Count();
        }

        public List<PostCollector> GetPostsCollector(string id)
        {
            Post[] posts = _context.Posts.Where(p => p.UserId == id).ToArray();
            List<PostCollector> resPosts = new List<PostCollector>();
            for (int i = 0; i < posts.Length; i++)
            {
                PostCollector pst = new PostCollector
                {
                    Post = posts[i],
                    Comments = _context.Comments.Where(x => x.PostId == posts[i].Id).ToList(),
                };
                resPosts.Add(pst);
            }
            return resPosts;
        }

        public void AddFollower(string flr, string flw)
        {
            Follower res = new Follower
            {
                FollowerId = flr,
                FollowingId = flw,
            };
            _context.Followers.Add(res);
            _context.SaveChanges();
        }

        public void DeleteFollower(string flr, string flw)
        {
            _context.Followers.Remove(_context.Followers.Where(i => i.FollowerId == flr && i.FollowingId == flw).ToArray()[0]);
            _context.SaveChanges();
        }

        public bool isFollwed(string id, string userId)
        {
            List<Follower> fl = _context.Followers.Where(i => i.FollowingId == id && i.FollowerId == userId).ToList();
            return fl.Count != 0;
        }

        public string GetUserByPostId(int postId)
        {
            string usr = _context.Posts.Where(i => i.Id == postId).ToArray()[0].UserId;
            return usr;
        }

        public List<Follower> GetFollowers(string id)
        {
            List<Follower> resFollowers = _context.Followers.Where(p => p.FollowerId == id).ToList();
            return resFollowers;
        }

        public List<Follower> GetFollowings(string id)
        {
            List<Follower> resFollowings = _context.Followers.Where(p => p.FollowingId == id).ToList();
            return resFollowings;
        }

        public UserCollector FindUser(string nickname)
        {
            SocialUser[] userLocal = _context.Users.Where(p => p.NickName == nickname).ToArray();
            if (userLocal.Length != 0)
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

        public List<UserCollector> FindUserByPrefix(string pref)
        {
            SocialUser[] userLocal = _context.Users.Where(p => p.NickName.ToLower().StartsWith(pref.ToLower())).ToArray();
            List<UserCollector> result = new List<UserCollector>();
            if (userLocal.Length != 0)
            {
                for (int i = 0; i < userLocal.Length; i++)
                {
                    result.Add(new UserCollector
                    {
                        User = userLocal[0],
                        Posts = GetPostsCollector(userLocal[0].Id),
                        Followers = GetFollowers(userLocal[0].Id),
                        Following = GetFollowings(userLocal[0].Id),
                    });
                }
            }
            return result;
        }

        public void AddComment(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }

        public void CreateUserLocal(SocialUser userLocal)
        {
            _context.Users.Add(userLocal);
            _context.SaveChanges();
        }

        public void UpdateUser(SocialUser user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public UserCollector GetUserCollector(string id)
        {
            UserCollector resultUser = new UserCollector
            {
                User = _context.Users.Where(p => p.Id == id).ToArray()[0],
                Posts = GetPostsCollector(id),
                Followers = GetFollowers(id),
                Following = GetFollowings(id),
            };
            return resultUser;
        }
    }
}
