using BlogSite.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.WebUI.Areas.Writer.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        private readonly IMessageService _messageService;
        public WriterMessageNotification(IMessageService messageService)
        {
            _messageService = messageService;
        }
    
        public async Task<IViewComponentResult> InvokeAsync()
        {
            int id;
            id = 1;
            var values = await _messageService.GetInboxWithByWriterAsync(id);
            return View(values);
        }
    }

}
