using BlogSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Business.Abstract
{
    public interface ICategoryService
    {
        Task AddAsync(Category category);
        Task DeleteAsync(Category category);
        Task DeleteAsync(int id);
        Task UpdateAsync(Category category);
        Task<List<Category>> GetListAsync();
        Task<Category> GetByIdAsync(int id);
        int AllCategoryCount();
    }
}
