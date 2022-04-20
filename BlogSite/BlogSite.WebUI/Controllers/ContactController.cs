using BlogSite.Business.Abstract;
using BlogSite.WebUI.Models.ViewModels.Contact;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(ContactAddVM contactVM)
        {
           await _contactService.ContactAddAsync(ContactAddVM.ConvertToContact(contactVM));
            return RedirectToAction("Index", "Blog");
        }
    }
}
