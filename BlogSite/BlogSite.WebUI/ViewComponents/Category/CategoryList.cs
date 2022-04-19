using BlogSite.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.WebUI.ViewComponents.Category
{
    public class CategoryList:ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public CategoryList(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _categoryService.GetListAsync());
        }
    }
}
