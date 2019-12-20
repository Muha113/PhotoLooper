using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PhotoLooper.Models;
using PhotoLooper.Services;
using PhotoLooper.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoLooper.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<SocialUser> _userManager;
        private readonly SignInManager<SocialUser> _signInManager;
        private readonly ILogger _logger;
        private readonly IDbService _context;
        private readonly IConfiguration _config;
        private readonly IEmailService _emailService;

        public AccountController(UserManager<SocialUser> userManager, SignInManager<SocialUser> signInManager, IEmailService emailService, ILogger<AccountController> logger, IConfiguration config, IDbService context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            //_logger.LogInformation($"\n\n\n{config["emailhost:email"]}\n\n\n");
            _config = config;
            _context = context;
            _emailService = emailService;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            _logger.LogInformation("\n\n--------------------------------Trying to register\n");
            if (ModelState.IsValid)
            {
                SocialUser user = new SocialUser {
                    Email = model.Email,
                    UserName = model.Email,
                    IsPostSavedLocal = true,
                    Name = "not set",
                    Surname = "not set",
                    Born = DateTime.MinValue,
                    NickName = model.NickName,
                    Description = "",
                    PhoneNumber = "not set",
                    AvatarPath = "",
                };
                // добавляем пользователя
                var result = await _userManager.CreateAsync(user, model.Password);
                var res = _userManager.Users.ToList();
                if (result.Succeeded)
                { 
                    // установка куки
                    await _signInManager.SignInAsync(user, false);
                    // генерация токена для пользователя
                    //var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    //var callbackUrl = Url.Action(
                    //    "ConfirmEmail",
                    //    "Account",
                    //    new { userId = user.Id, code = code },
                    //    protocol: HttpContext.Request.Scheme);
                    //await _emailService.SendEmailAsync(model.Email, "Confirm your account",
                    //    $"Подтвердите регистрацию, перейдя по ссылке: <a href='{callbackUrl}'>link</a>", _config);

                    //return Content("Для завершения регистрации проверьте электронную почту и перейдите по ссылке, указанной в письме");
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }


        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return View("Error");
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return View("Error");
            }
            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
                return RedirectToAction("Index", "Home");
            else
                return View("Error");
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            _logger.LogInformation("\n\n--------------------------------Trying to log in\n");
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.Email);
               /* if (user != null)
                {
                    // проверяем, подтвержден ли email
                    if (!await _userManager.IsEmailConfirmedAsync(user))
                    {
                        ModelState.AddModelError(string.Empty, "Вы не подтвердили свой email");
                        return View(model);
                    }
                }*/

                var result =
                    await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe = true, false);
                if (result.Succeeded)
                {
                    // проверяем, принадлежит ли URL приложению
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Неправильный логин и (или) пароль");
                }
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOff()
        {
            //_context.CreatePost(new Post
            //{
            //    UserId = StaticUser.Id,
            //    Path = "dshfsugdfisg",
            //});
            // удаляем аутентификационные куки
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
