using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.WebUI.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
