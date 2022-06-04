using BlogSite.Business.Abstract;
using BlogSite.Entities.Concrete;
using BlogSite.WebUI.Models.ViewModels.Login;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlogSite.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IWriterService _writerService;
        
        public LoginController(IWriterService writerService)
        {
            _writerService = writerService;

        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                Writer writer = await _writerService.GetByPasswordAndEmail(loginVM.Email, loginVM.Password);
                if (writer != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,writer.Email)
                    };
                    var userIdentity = new ClaimsIdentity(claims,"a");
                    
                    ClaimsPrincipal principal = new ClaimsPrincipal();
                    principal.AddIdentity(userIdentity);
                    
                    await HttpContext.SignInAsync(principal);
                    
                    return RedirectToAction("Index", "Writer", new { @area = "Writer" });
                }
                ViewBag.SignControlMessage = "Kullanıcı Adı Veya Parolanız Yanlış.";
                return View();
            }
            return View(loginVM);
        }


        //[HttpPost]
        //[AllowAnonymous]
        //public async Task<IActionResult> Index(LoginVM loginVM)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Writer writer = await _writerService.GetByPasswordAndEmail(loginVM.Email, loginVM.Password);
        //        if (writer!=null)
        //        {
        //            HttpContext.Session.SetString("username",loginVM.Email);
                     
                    
        //            return RedirectToAction("Index", "Writer");
        //        }
        //        ViewBag.SignControlMessage = "Kullanıcı Adı Veya Parolanız Yanlış.";
        //        return View();
        //    }
        //    return View(loginVM);
        //}
    }
}
