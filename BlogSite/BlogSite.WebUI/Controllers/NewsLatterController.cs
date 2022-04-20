using BlogSite.Business.Abstract;
using BlogSite.Entities.Concrete;
using BlogSite.WebUI.Models.ViewModels.NewsLatter;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.WebUI.Controllers
{
    public class NewsLatterController : Controller
    {
        private readonly INewsLatterService _newsLatterService;
        public NewsLatterController(INewsLatterService newsLatterService)
        {
            _newsLatterService = newsLatterService;
        }
        public async Task<PartialViewResult> _SubscribeMailPartial()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<PartialViewResult> _SubscribeMailPartial(MailPostVM newsLatter)
        {
            await _newsLatterService.AddNewsLatterAsync(MailPostVM.ConvertToNewsLatter(newsLatter));
            return PartialView();
        }

    }
}
