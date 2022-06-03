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
        Task StatusUpdateAsync(int? id);
        Task UpdateAsync(Blog blog);
        Task<List<Blog>> GetListAsync();
        Task<List<Blog>> GetListWithCategoryAsync();
        Task<List<Blog>> GetListByWriterIdAsync(int id);
        Task<IEnumerable<Blog>> GetListThreeBlogAsync();
        Task<Blog> GetByIdAsync(int id);
        Task<List<Blog>> GetListWithCategoryByWriterId(int writerId);

        int BlogCount();
        int BlogCountWithWriterId(int id);

    }
}
