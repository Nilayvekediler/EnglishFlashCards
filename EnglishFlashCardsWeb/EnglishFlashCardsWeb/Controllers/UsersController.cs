using EnglishFlashCardsWeb.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EnglishFlashCardsWeb.Controllers
{
   
    public class UsersController : Controller
    {
        Context cnt = new Context();

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult newUser()
        {
            return View();
        }

        public IActionResult Hata()
        {
            return View();
        }

        [HttpPost]
        public IActionResult newUser(string username, string password, string email)
        {

            User user = new User();
            user.userName = username;
            user.Password = password;
            user.email = email;
            UserManager userManager = new UserManager(user);
            ViewBag.result = userManager.addUser();
            return View("newUserResult");
        }

        public async Task<IActionResult> login(string username, string password)
        {
            User user = new User();
            user.userName = username;
            user.Password = password;
            UserManager userManager = new UserManager();
            if (userManager.userLogin(user))
            {

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,user.userName)
                };
                var useridentity = new ClaimsIdentity(claims,"login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Sets");
            } else
            {
                return RedirectToAction("hata");
            }
        }

        public async Task<IActionResult> logout()
        {
            await HttpContext.SignOutAsync(
            CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("", "home");
        }

       

    }
}
