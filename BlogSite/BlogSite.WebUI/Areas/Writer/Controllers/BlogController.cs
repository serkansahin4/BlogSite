using BlogSite.Business.Abstract;
using BlogSite.Business.ValidationRules.BlogValidation;
using BlogSite.Entities.Concrete;
using BlogSite.WebUI.Areas.Writer.Models.ViewModels.Blog;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.WebUI.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICategoryService _categoryService;
        public BlogController(IBlogService blogService,ICategoryService categoryService)
        {
            _blogService = blogService;
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _blogService.GetListWithCategoryByWriterId(2));
        }

        [HttpGet]
        public async Task<IActionResult> AddBlog()
        {

            IEnumerable<SelectListItem> categoryList = from catList in await _categoryService.GetListAsync()
                    select new SelectListItem
                    {
                        Value = catList.Id.ToString(),
                        Text = catList.Name
                    };
            ViewBag.CategoryList = categoryList;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddBlog(AddBlogVM addBlogVM)
        {
            if (ModelState.IsValid)
            {
                BlogValidator validationRules = new BlogValidator();
                ValidationResult result = validationRules.Validate(AddBlogVM.ConvertToBlog(addBlogVM));
                if (result.IsValid)
                {
                    await _blogService.AddAsync(AddBlogVM.ConvertToBlog(addBlogVM));
                    return RedirectToAction("Index", "Blog", new { @area = "Writer" });
                }

                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }
            return View();
        }

        public async Task<IActionResult> ChangeStatusBlog(int? id)
        {
            await _blogService.StatusUpdateAsync(id);
            return RedirectToAction("Index", "Blog");
        }

        public async Task<IActionResult> DeleteBlog(int id)
        {
            await _blogService.DeleteAsync(id);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public async Task<IActionResult> EditBlog(int id)
        {
            IEnumerable<SelectListItem> categoryList = from catList in await _categoryService.GetListAsync()
                                                       select new SelectListItem
                                                       {
                                                           Value = catList.Id.ToString(),
                                                           Text = catList.Name
                                                       };
            ViewBag.CategoryList = categoryList;
            return View(await _blogService.GetByIdAsync(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditBlog(Blog blog)
        {
            BlogValidator validationRules = new BlogValidator();
            ValidationResult result= validationRules.Validate(blog);
            if (result.Errors.Count>0)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            await _blogService.UpdateAsync(blog);
            return RedirectToAction("Index");
        }
    }
}
