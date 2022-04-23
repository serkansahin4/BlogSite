using BlogSite.Business.Abstract;
using BlogSite.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
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
        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _blogService.GetListByWriterIdAsync(2));
        }
    }
}
