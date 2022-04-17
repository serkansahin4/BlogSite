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
    public class EfCategoryDal:EfEntityRepositoryBase<Category>,ICategoryDal
    {
        public EfCategoryDal(BlogSiteContext blogSiteContext):base(blogSiteContext)
        {
            
        }
    }
}
