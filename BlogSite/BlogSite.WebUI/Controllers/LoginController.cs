using BlogSite.Business.Abstract;
using BlogSite.Entities.Concrete;
using BlogSite.WebUI.Models.ViewModels.Login;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                Writer writer = await _writerService.GetByPasswordAndEmail(loginVM.Email, loginVM.Password);
                if (writer!=null)
                {
                    return RedirectToAction("Index", "Blog");
                }
                ViewBag.SignControlMessage = "Kullanıcı Adı Veya Parolanız Yanlış.";
                return View();
            }
            return View(loginVM);
        }
    }
}
