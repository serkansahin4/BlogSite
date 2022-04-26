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
    public class EfBlogDal : EfEntityRepositoryBase<Blog>, IBlogDal
    {
        public EfBlogDal(BlogSiteContext context) : base(context)
        {

        }

        public async Task<List<Blog>> GetListWithCategoryAsync()
        {
            return await _dbSet.Include(x => x.Category).ToListAsync();
        }

        public async Task<List<Blog>> GetListWithCategoryByWriterId(int writerId)
        {
            return await _dbSet.Include(x => x.Category).Where(x => x.WriterId==writerId).ToListAsync();
        }
    }
}
