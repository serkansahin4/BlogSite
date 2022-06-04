using BlogSite.DataAccess.Abstract;
using BlogSite.DataAccess.Concrete.EntityFramework.Context;
using BlogSite.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.DataAccess.Concrete.EntityFramework
{
    public class EfMessageDal:EfEntityRepositoryBase<Message>,IMessageDal
    {
        public EfMessageDal(BlogSiteContext context):base(context)
        {

        }

        public async Task<List<Message>> GetListWithMessageByWriterId(int writerId)
        {
            return await _dbSet.Include(x => x.SenderWriter).Where(x => x.ReceiverWriterId==writerId).ToListAsync();
        }
    }
}
