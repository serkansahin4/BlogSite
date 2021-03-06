using BlogSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.DataAccess.Abstract
{
    public interface IMessageDal:IRepository<Message>
    {
        Task<List<Message>> GetListWithMessageByWriterId(int writerId);
    }
}
