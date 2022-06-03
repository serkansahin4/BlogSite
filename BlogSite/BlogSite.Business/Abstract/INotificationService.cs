using BlogSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Business.Abstract
{
    public interface INotificationService
    {
        Task AddAsync(Notification notification);
        Task DeleteAsync(int id);
        Task UpdateAsync(Notification notification);
        Task<List<Notification>> GetListAsync();
        Task<Notification> GetByIdAsync(int id);
    }
}
