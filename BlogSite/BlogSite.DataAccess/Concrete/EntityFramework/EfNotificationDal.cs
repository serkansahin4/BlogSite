using BlogSite.DataAccess.Abstract;
using BlogSite.DataAccess.Concrete.EntityFramework.Context;
using BlogSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.DataAccess.Concrete.EntityFramework
{
    public class EfNotificationDal:EfEntityRepositoryBase<Notification>,INotificationDal
    {
        public EfNotificationDal(BlogSiteContext context) : base(context)
        {
            
        }
    }
}
