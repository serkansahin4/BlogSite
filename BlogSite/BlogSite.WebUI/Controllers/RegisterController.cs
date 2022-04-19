using BlogSite.Business.Abstract;
using BlogSite.Business.ValidationRules.WriterValidation;
using BlogSite.WebUI.Models.ViewModels.Register;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IWriterService _writerService;
        public RegisterController(IWriterService writerService)
        {
            _writerService = writerService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterVM registerVM)
        {
            if (ModelState.IsValid)
            {
                WriterValidator validationRules = new WriterValidator();
                ValidationResult result= validationRules.Validate(RegisterVM.ConvertToWriter(registerVM));
                if (result.IsValid)
                {
                    await _writerService.AddAsync(RegisterVM.ConvertToWriter(registerVM));
                    return RedirectToAction("Index", "Blog");
                }
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
