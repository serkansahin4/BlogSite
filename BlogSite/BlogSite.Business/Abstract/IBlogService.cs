using BlogSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Business.Abstract
{
    public interface IBlogService
    {
        Task AddAsync(Blog blog);
        Task DeleteAsync(Blog blog);
        Task DeleteAsync(int id);
        Task UpdateAsync(Blog blog);
        Task<List<Blog>> GetListAsync();
        Task<Blog> GetByIdAsync(int id);
    }
}
