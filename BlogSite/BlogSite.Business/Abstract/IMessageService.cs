using BlogSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Business.Abstract
{
    public interface IMessageService
    {
        Task AddAsync(Message message);
        Task DeleteAsync(int id);
        Task StatusUpdateAsync(int? id);
        Task UpdateAsync(Message message);
        Task<List<Message>> GetListAsync();
        Task<List<Message>> GetInboxWithByWriterAsync(string p);
    }
}
