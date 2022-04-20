using BlogSite.Business.Abstract;
using BlogSite.WebUI.Models.ViewModels.Comment;
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
       
        public async Task<PartialViewResult> _CommentListByBlogPartial(int id)
        {
            return PartialView(await _commentService.GetListByBlogIdAsync(id));
        }
        public PartialViewResult _CommentAddPartial()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<PartialViewResult> _CommentAddPartial(CommentVM commentVM)
        {
            await _commentService.AddAsync(CommentVM.ConvertToComment(commentVM));
            return PartialView();
        }
    }
}
