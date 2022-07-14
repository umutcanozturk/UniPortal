using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using WebProgramlamaOdev.Core.Models;
using WebProgramlamaOdev.Models;

namespace WebProgramlamaOdev.Controllers
{
    
    public class LoginController : Controller
    {
        public LoginController()
        {

        }
        [HttpGet]
        public IActionResult Login(string ReturnUrl = "/")
        {
            ViewData["ReturnUrl"] = ReturnUrl;
            return View();
        }
        public IActionResult KayitOl()
        {
            return View();
        }
        public IActionResult Denied()
        {
          
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModelBase loginModel)
        {
            if (LoginUser(loginModel.Emaild, loginModel.Password))
            {
                var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, loginModel.Emaild)
            };

                var claimsIdentity = new ClaimsIdentity(
               claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity));

                return LocalRedirect(loginModel.ReturnUrl);
            }
            return RedirectToAction("Login", "Login");
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Index","Home");
        }

        private bool LoginUser(string mail, string password)
        {
            
                WebClient webClient = new WebClient();
                webClient.QueryString.Add("mail", mail);
                webClient.QueryString.Add("pw", password);
                var result = webClient.DownloadString("https://localhost:44385/Login/Validate");
            if (result=="true")
            {
                return true;
            }
            else { return false; }




        }
    }
}
