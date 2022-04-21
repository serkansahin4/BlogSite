using BlogSite.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.WebUI.ViewComponents.Blog
{
    public class LastThreeBlog:ViewComponent
    {
        private readonly IBlogService _blogService;
        public LastThreeBlog(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _blogService.GetListThreeBlogAsync());
        }
    }
}
