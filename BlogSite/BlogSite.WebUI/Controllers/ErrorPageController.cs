using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.WebUI.Controllers
{
    public class ErrorPageController : Controller
    {
        public async Task<IActionResult> Error(int code)
        {
            return View();
        }
    }
}
