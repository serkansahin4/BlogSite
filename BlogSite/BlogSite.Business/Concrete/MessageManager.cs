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
    public class MessageManager : IMessageService
    {
        private readonly IMessageDal _messageDal;
        
        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }
        public Task AddAsync(Message message)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Message> GetById(int id)
        {
            return await _messageDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<Message>> GetInboxWithByWriterAsync(int id)
        {
            return await _messageDal.GetListWithMessageByWriterId(id);

        }

        public async Task<List<Message>> GetListAsync()
        {
            return await _messageDal.GetAllAsync();
        }


        public Task StatusUpdateAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
