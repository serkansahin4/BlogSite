using BlogSite.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.WebUI.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult _CommentAddPartial()
        {
            return PartialView();
        }

        public async Task<PartialViewResult> _CommentListByBlogPartial(int id)
        {
            return PartialView(await _commentService.GetListByBlogIdAsync(id));
        }
    }
}
