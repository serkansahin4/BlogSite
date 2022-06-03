using BlogSite.Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlogSite.WebUI.Areas.Writer.Controllers
{
    [AllowAnonymous]
    public class NotificationController : Controller
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> AllNotification()
        {
            return View(await _notificationService.GetListAsync());
        }
    }
}
