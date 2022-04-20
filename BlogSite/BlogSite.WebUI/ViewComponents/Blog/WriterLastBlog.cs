using BlogSite.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.WebUI.ViewComponents.Blog
{
    public class WriterLastBlog:ViewComponent
    {
        private readonly IBlogService _blogService;
        public WriterLastBlog(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            return View(await _blogService.GetListByWriterIdAsync(2));
        }
    }
}
