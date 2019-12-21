using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PhotoLooper.Models;
using PhotoLooper.Services;

namespace PhotoLooper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IDbService _context;
        public UserManager<SocialUser> _userManager;
        public IHostingEnvironment _appEnvironment;

        public HomeController(ILogger<HomeController> logger, IDbService context, UserManager<SocialUser> userManager, IHostingEnvironment appEnvironment)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
            _appEnvironment = appEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            if (!User.Identity.IsAuthenticated)
                return RedirectToAction("Login", "Account");
            SocialUser usr = await _userManager.GetUserAsync(User);
            return View(_context.GetUserCollector(usr.Id));
        }

        public IActionResult Privacy()
        {
            Response.StatusCode = 404;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Follow(string postId)
        {
            SocialUser usr = await _userManager.GetUserAsync(User);
            _context.AddFollower(usr.Id, postId);
            return RedirectToAction("Index", "Home");
        }
        
        [HttpPost]
        public async Task<IActionResult> Unfollow(string postId)
        {
            SocialUser usr = await _userManager.GetUserAsync(User);
            _context.DeleteFollower(usr.Id, postId);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Tape()
        {
            SocialUser user = await _userManager.GetUserAsync(User);
            List<Follower> fl = _context.GetFollowers(user.Id);
            List<PostCollector> res = new List<PostCollector>();
            List<UserCollector> usr = new List<UserCollector>();
            ViewBag.context = _context;
            foreach (var x in fl)
            {
                usr.Add(_context.GetUserCollector(x.FollowingId));
                res.AddRange(_context.GetPostsCollector(x.FollowingId));
            }
            List<PostCollector> sortedRes = res.OrderByDescending(i => i.Post.DateTime).ToList();
            ViewBag.UsersColl = _context;
            return View(sortedRes);
        }

        public async Task<IActionResult> Photo(int selected)
        {
            SocialUser user = await _userManager.GetUserAsync(User);
            string usrId = _context.GetUserByPostId(selected);
            ViewBag.context = _context;
            ViewBag.user = user;
            foreach(var x in _context.GetPostsCollector(usrId))
            {
                if (x.Post.Id == selected)
                {
                    return View(x);
                }
            }
            return View();
        }

        public async Task<IActionResult> SetUserAvatar(string path, int postId)
        {
            SocialUser user = await _userManager.GetUserAsync(User);
            string newPath = "";
            for(int i = 0; i < path.Length - 1; i++)
            {
                newPath += path[i];
            }
            SocialUser usr = _context.GetUserCollector(user.Id).User;
            usr.AvatarPath = newPath;
            _context.UpdateUser(usr);
            return RedirectToAction("Photo", "Home", new { selected = postId });
        }

        public async Task<IActionResult> Profile(string id)
        {
            SocialUser user = await _userManager.GetUserAsync(User);

            if (id == null) { id = user.Id; }
            if (_context.isFollwed(id, user.Id))
            {
                ViewBag.isFollowed = true;
            }
            else
            {
                ViewBag.isFollowed = false;
            }
            ViewBag.context = _context;
            ViewBag.user = user;
            return View(_context.GetUserCollector(id));
        }

        public async Task<IActionResult> EditProfile()
        {
            SocialUser user = await _userManager.GetUserAsync(User);
            SocialUser usr = _context.GetUserCollector(user.Id).User;
            return View(usr);
        }

        public async Task<IActionResult> Settings()
        {
            SocialUser user = await _userManager.GetUserAsync(User);
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string userName, string userSurname, DateTime userBorn, string userPhone, string userDesc)
        {
            SocialUser user = await _userManager.GetUserAsync(User);
            UserCollector usr = _context.GetUserCollector(user.Id);
            SocialUser res = usr.User;
            res.Name = userName;
            res.Surname = userSurname;
            res.Born = userBorn;
            res.PhoneNumber = userPhone;
            res.Description = userDesc;
            _context.UpdateUser(res);
            return RedirectToAction("Profile", "Home");
        }

        public async Task<IActionResult> UploadFile()
        {
            SocialUser user = await _userManager.GetUserAsync(User);
            _logger.LogInformation("MEMKEK");
            return View(_context.GetPostsCollector(user.Id));
        }

        public IActionResult Search(string s)
        {
            List<UserCollector> usr = new List<UserCollector>();
            if (s != null)
            {
                usr = _context.FindUserByPrefix(s);
            }
            return View(usr);
        }

        public async Task<IActionResult> OnSelectedSavingType(string selected)
        {
            SocialUser user = await _userManager.GetUserAsync(User);
            if (selected == "In Cloud")
            {
                user.IsPostSavedLocal = false;
            }
            else
            {
                user.IsPostSavedLocal = true;
            }
            _context.UpdateUser(user);
            return RedirectToAction("Settings", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public async Task<IActionResult> AddFile(IFormFile file)
        {
            SocialUser user = await _userManager.GetUserAsync(User);
            if (file != null)
            {
                string path;
                if (user.IsPostSavedLocal)
                {
                    path = _context.UploadImageLocalSync(user, file, _appEnvironment);
                }
                else
                {
                    byte[] imageArray = System.IO.File.ReadAllBytes("wwwroot/Files/no_avatar.png");
                    string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                    path = await _context.UploadImageOnCloudAsync(base64ImageRepresentation);
                }
                _context.CreatePost(new Post { UserId = user.Id, Path = path, DateTime = DateTime.Now });
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task TypeComment(string com, int pId) 
        {
            SocialUser user = await _userManager.GetUserAsync(User);
            if (com != "")
            {
                _context.AddComment(new Comment { comment = com, PostId = pId, UserId = user.Id });
            }
        }
    }
}
