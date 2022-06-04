using BlogSite.Business.Abstract;
using BlogSite.Business.ValidationRules.WriterValidation;
using BlogSite.WebUI.Areas.Writer.Models.ViewModels.Writer;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.WebUI.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    public class WriterController : Controller
    {
        private readonly IWriterService _writerService;

        public WriterController(IWriterService writerService)
        {
            _writerService = writerService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            
            return View(_writerService.GetByEmailAsync(User.Identity.Name).Result);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(WriterUpdateVM writerUpdateVM)
        {
            if (ModelState.IsValid)
            {
                WriterValidator rules = new WriterValidator();
                ValidationResult result = rules.Validate(WriterUpdateVM.ConvertToWriter(writerUpdateVM));
                if (result.IsValid)
                {
                    _writerService.UpdateAsync(WriterUpdateVM.ConvertToWriter(writerUpdateVM)).Wait();
                    return View();
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    }
                }
            }
            
            return View(_writerService.GetByEmailAsync("serkan@hotmail.com").Result);
        }

        [HttpGet]
        public async Task<IActionResult> WriterAdd()
        {
            return View();
        }
        [HttpGet]
        public IActionResult WriterIndex()
        {
            var us = User.Identity.Name;
            ViewBag.UserName = us;
            return View();
        }

        [HttpPost("Writer/Writer/WriterAdd")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> WriterAdd(WriterAddVM writerAddVM)
        {
            BlogSite.Entities.Concrete.Writer writer = new BlogSite.Entities.Concrete.Writer();
            if (writerAddVM.Image!=null)
            {
                var extension = Path.GetExtension(writerAddVM.Image.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                writerAddVM.Image.CopyTo(stream);
                writer.Image = newImageName;

            }
            writer.Email = writerAddVM.Email;
            writer.About = writerAddVM.About;
            writer.Name = writer.Name;
            writer.Status = true;
            writer.Password = writer.Password;

            await _writerService.AddAsync(writer);
            return RedirectToAction("Index","Writer",new {@area="Writer" });
        }
    }
}
