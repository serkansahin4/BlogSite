using BlogSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Business.Abstract
{
    public interface IWriterService
    {
        Task AddAsync(Writer writer);
        Task DeleteAsync(Writer writer);
        Task DeleteAsync(int id);
        Task UpdateAsync(Writer writer);
        Task<List<Writer>> GetListByBlogIdAsync(int id);
        Task<Writer> GetByEmailAsync(string id);
        Task<Writer> GetByPasswordAndEmail(string email,string password);
    }
}
