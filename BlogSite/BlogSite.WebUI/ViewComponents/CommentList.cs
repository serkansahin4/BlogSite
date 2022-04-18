using BlogSite.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.WebUI.ViewComponents
{
    public class CommentList:ViewComponent
    {
        private readonly ICommentService _commentService;
        public CommentList(ICommentService commentService)
        {
            _commentService = commentService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            return View(await _commentService.GetListByBlogIdAsync(id));
        }
    }
}
