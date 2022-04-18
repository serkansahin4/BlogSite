using BlogSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Business.Abstract
{
    public interface ICommentService
    {
        Task AddAsync(Comment comment);
        Task DeleteAsync(Comment comment);
        Task DeleteAsync(int id);
        Task UpdateAsync(Comment comment);
        Task<List<Comment>> GetListByBlogIdAsync(int id);
        Task<Comment> GetByIdAsync(int id);
    }
}
