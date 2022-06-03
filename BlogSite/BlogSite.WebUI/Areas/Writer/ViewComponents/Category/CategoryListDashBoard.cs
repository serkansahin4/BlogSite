using BlogSite.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.WebUI.Areas.Writer.ViewComponents.Category
{
    public class CategoryListDashBoard:ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public CategoryListDashBoard(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _categoryService.GetListAsync());
        }
    }
}
