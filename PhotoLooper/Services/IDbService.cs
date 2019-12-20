using PhotoLooper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoLooper.Services
{
    public interface IDbService
    {
        public void CreatePost(Post post);
        public List<PostCollector> GetPostsCollector(int id);
        public void AddFollower(int flr, int flw);
        public void DeleteFollower(int flr, int flw);
        public bool isFollwed(int id, int userId);
        public int GetUserByPostId(int postId);
        public List<Follower> GetFollowers(int id);
        public List<Follower> GetFollowings(int id);
        public UserCollector FindUser(string nickname);
        public void AddComment(Comment comment);
        public void CreateUserLocal(UserLocal userLocal);
        public void UpdateUser(UserLocal user);
        public UserCollector GetUserCollector(int id);
        public int GetPostsAmount(int id);
        public List<UserCollector> FindUserByPrefix(string pref);
    }
}
