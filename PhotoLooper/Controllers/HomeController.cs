using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PhotoLooper.Models;

namespace PhotoLooper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public ApplicationContext _context;
        public UserManager<User> _userManager;
        public IHostingEnvironment _appEnvironment;

        public HomeController(ILogger<HomeController> logger, ApplicationContext context, UserManager<User> userManager, IHostingEnvironment appEnvironment)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
            _appEnvironment = appEnvironment;
        }

        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
                return RedirectToAction("Login", "Account");
            //Response.StatusCode = 404;
            return View(_context.GetUserCollector(StaticUser.GetUserId(User.Identity.Name)));
        }

        public IActionResult Privacy()
        {
            Response.StatusCode = 404;
            return View();
        }

        [HttpPost]
        public IActionResult Follow(int postId)
        {
            _context.AddFollower(StaticUser.GetUserId(User.Identity.Name), postId);
            return RedirectToAction("Index", "Home");
        }
        
        [HttpPost]
        public IActionResult Unfollow(int postId)
        {
            _context.DeleteFollower(StaticUser.GetUserId(User.Identity.Name), postId);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Tape()
        {
            List<Follower> fl = _context.GetFollowers(StaticUser.GetUserId(User.Identity.Name));
            List<PostCollector> res = new List<PostCollector>();
            List<UserCollector> usr = new List<UserCollector>();
            foreach (var x in fl)
            {
                usr.Add(_context.GetUserCollector(x.FollowingId));
                res.AddRange(_context.GetPostsCollector(x.FollowingId));
            }
            List<PostCollector> sortedRes = res.OrderByDescending(i => i.Post.DateTime).ToList();
            ViewBag.UsersColl = _context;
            return View(sortedRes);
        }

        public IActionResult Photo(int selected)
        {
            int usrId = _context.GetUserByPostId(selected);
            ViewBag.context = _context;
            foreach(var x in _context.GetPostsCollector(usrId))
            {
                if (x.Post.Id == selected)
                {
                    return View(x);
                }
            }
            return View();
        }

        public IActionResult SetUserAvatar(string path, int postId)
        {
            UserLocal usr = _context.GetUserCollector(StaticUser.GetUserId(User.Identity.Name)).User;
            usr.AvatarPath = path;
            _context.UpdateUser(usr);
            return RedirectToAction("Photo", "Home", new { selected = postId });
        }

        public IActionResult Profile(int id)
        {
            if (id == 0) { id = StaticUser.GetUserId(User.Identity.Name); }
            if (_context.isFollwed(id, StaticUser.GetUserId(User.Identity.Name)))
            {
                ViewBag.isFollowed = true;
            }
            else
            {
                ViewBag.isFollowed = false;
            }
            ViewBag.context = _context;
            return View(_context.GetUserCollector(id));
        }

        public IActionResult EditProfile()
        {
            UserLocal usr = _context.GetUserCollector(StaticUser.GetUserId(User.Identity.Name)).User;
            return View(usr);
        }

        [HttpPost]
        public IActionResult Edit(string userName, string userSurname, DateTime userBorn, string userPhone, string userDesc)
        {
            UserCollector usr = _context.GetUserCollector(StaticUser.GetUserId(User.Identity.Name));
            UserLocal res = usr.User;
            res.Name = userName;
            res.Surname = userSurname;
            res.Born = userBorn;
            res.Phone = userPhone;
            res.Description = userDesc;
            _context.UpdateUser(res);
            return RedirectToAction("Profile", "Home");
        }

        public IActionResult UploadFile()
        {
            _logger.LogInformation("MEMKEK");
            return View(_context.GetPostsCollector(StaticUser.GetUserId(User.Identity.Name)));
        }

        public IActionResult Search(string s)
        {
            UserCollector user = _context.FindUser(s);
            if (user != null)
            {
                return RedirectToAction("Profile", "Home", new { id = user.User.UserId });
            }
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult AddFile(IFormFile file)
        {
            if (file != null)
            {
                // путь к папке Files
                string fileName = _context.GetUserCollector(StaticUser.GetUserId(User.Identity.Name)).User.UserId.ToString() + "file" + _context.Posts.Where(p => p.UserId == StaticUser.GetUserId(User.Identity.Name)).Count().ToString();
                string path = "/Files/" + fileName + ".png";
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                _context.Posts.Add(new Post { UserId = StaticUser.GetUserId(User.Identity.Name), Path = path , DateTime = DateTime.Now});
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public void TypeComment(string com, int pId) 
        {
            Console.WriteLine("SOSISISISIIS");
            if (com != "")
            {
                //int tmp = StaticUser.GetUserId(User.Identity.Name);
                _context.AddComment(new Comment { comment = com, PostId = pId, UserId = StaticUser.GetUserId(User.Identity.Name) });
            }
            //return RedirectToAction("Photo", "Home", new { selected = pId });
        }
    }
}
