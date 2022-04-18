using BlogSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.DataAccess.Abstract
{
    public interface IBlogDal:IRepository<Blog>
    {
        Task<List<Blog>> GetListWithCategoryAsync();
    }
}
