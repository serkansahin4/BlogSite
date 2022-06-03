using BlogSite.Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.WebUI.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICategoryService _categoryService;

        public DashboardController(IBlogService blogService, ICategoryService categoryService)
        {
            _blogService = blogService;
            _categoryService = categoryService;
        }


        [AllowAnonymous]
        public IActionResult Index()
        {
            ViewBag.BlogCount = _blogService.BlogCount();
            ViewBag.BlogWriterCount = _blogService.BlogCountWithWriterId(2);
            ViewBag.CategoryCount = _categoryService.AllCategoryCount();
            return View();
        }
    }
}
