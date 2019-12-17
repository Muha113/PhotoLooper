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
            return View(_context.GetUserCollector(StaticUser.Id));
        }

        public IActionResult Privacy()
        {
            Response.StatusCode = 404;
            return View();
        }

        [HttpPost]
        public IActionResult Follow(int postId)
        {
            _context.AddFollower(StaticUser.Id, postId);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Tape()
        {
            List<Follower> fl = _context.GetFollowers(StaticUser.Id);
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
            foreach(var x in _context.GetPostsCollector(usrId))
            {
                if (x.Post.Id == selected)
                {
                    return View(x);
                }
            }
            return View();
        }

        public IActionResult Profile(int id)
        {
            if (id == 0) { id = StaticUser.Id; }
            return View(_context.GetUserCollector(id));
        }

        public IActionResult UploadFile()
        {
            _logger.LogInformation("MEMKEK");
            return View(_context.GetPostsCollector(StaticUser.Id));
        }

        public IActionResult Search(string s)
        {
            UserCollector user = _context.FindUser(s);
            if (user.User != null)
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
                string fileName = _context.GetUserCollector(StaticUser.Id).User.UserId.ToString() + "file" + _context.Posts.Where(p => p.UserId == StaticUser.Id).Count().ToString();
                string path = "/Files/" + fileName + ".png";
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                _context.Posts.Add(new Post { UserId = StaticUser.Id, Path = path , DateTime = DateTime.Now});
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult TypeComment(string com, int pId)
        {
            if (com != "")
            {
                _context.AddComment(new Comment { comment = com, PostId = pId });
            }
            return RedirectToAction("Photo", "Home", new { selected = pId});
        }
    }
}
