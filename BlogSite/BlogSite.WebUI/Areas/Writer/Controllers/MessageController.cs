using BlogSite.Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlogSite.WebUI.Areas.Writer.Controllers
{
    [AllowAnonymous]
    [Area("Writer")]
    public class MessageController : Controller
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public async Task<IActionResult> InBox()
        {
            int id;
            id = 1;
            var values = await _messageService.GetInboxWithByWriterAsync(2);
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> MessageDetails(int id)
        {
            var value = await _messageService.GetById(id);
            return View(value);
        }
    }
}
