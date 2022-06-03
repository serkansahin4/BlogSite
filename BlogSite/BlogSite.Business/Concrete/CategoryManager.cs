using BlogSite.Business.Abstract;
using BlogSite.DataAccess.Abstract;
using BlogSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public async Task AddAsync(Category category)
        {
            await _categoryDal.InsertAsync(category);
        }

        public int AllCategoryCount()
        {
            return _categoryDal.GetAllAsync().Result.Count;
        }

        public async Task DeleteAsync(Category category)
        {
            await _categoryDal.DeleteAsync(category);
        }

        public async Task DeleteAsync(int id)
        {
            Category category = await GetByIdAsync(id);
            await _categoryDal.DeleteAsync(category);
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await _categoryDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<Category>> GetListAsync()
        {
            return await _categoryDal.GetAllAsync();
        }

        public async Task UpdateAsync(Category category)
        {
            await _categoryDal.UpdateAsync(category);
        }
    }
}
