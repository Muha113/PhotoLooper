using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
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
        public List<PostCollector> GetPostsCollector(string id);
        public void AddFollower(string flr, string flw);
        public void DeleteFollower(string flr, string flw);
        public bool isFollwed(string id, string userId);
        public string GetUserByPostId(int postId);
        public List<Follower> GetFollowers(string id);
        public List<Follower> GetFollowings(string id);
        public UserCollector FindUser(string nickname);
        public void AddComment(Comment comment);
        public void CreateUserLocal(SocialUser userLocal);
        public void UpdateUser(SocialUser user);
        public UserCollector GetUserCollector(string id);
        public int GetPostsAmount(string id);
        public List<UserCollector> FindUserByPrefix(string pref);
        public Task<string> UploadImageOnCloudAsync(string imageDataBase64String);
        public string UploadImageLocalSync(SocialUser user, IFormFile file,
            Microsoft.AspNetCore.Hosting.IHostingEnvironment _appEnvironment);
    }
}
