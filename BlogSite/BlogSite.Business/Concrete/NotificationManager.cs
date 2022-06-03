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
    public class NotificationManager : INotificationService
    {
        private readonly INotificationDal _notificationDal;
        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }
        public async Task AddAsync(Notification notification)
        {
            await _notificationDal.InsertAsync(notification);
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Notification> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Notification>> GetListAsync()
        {
            return await _notificationDal.GetAllAsync();
        }

        public Task UpdateAsync(Notification notification)
        {
            throw new NotImplementedException();
        }
    }
}
