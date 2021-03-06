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
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        public async Task AddAsync(Blog blog)
        {
            
            await _blogDal.InsertAsync(blog);
        }

        public int BlogCount()
        {
           return _blogDal.GetAllAsync().Result.Count();
        }

        public int BlogCountWithWriterId(int id)
        {
            return _blogDal.GetAllAsync(x=>x.WriterId==id).Result.Count();
        }

        public async Task DeleteAsync(Blog blog)
        {
            await _blogDal.DeleteAsync(blog);

        }

        public async Task DeleteAsync(int id)
        {
           Blog blog= await GetByIdAsync(id);
            await _blogDal.DeleteAsync(blog);

        }

        public async Task<Blog> GetByIdAsync(int id)
        {
            return await _blogDal.GetAsync(x=>x.Id==id);
        }

        public async Task<List<Blog>> GetListAsync()
        {
            return await _blogDal.GetAllAsync();
        }

        public async Task<List<Blog>> GetListByWriterIdAsync(int id)
        {
            return await _blogDal.GetAllAsync(x => x.WriterId == id);
        }

        public async Task<IEnumerable<Blog>> GetListThreeBlogAsync()
        {
            IEnumerable<Blog> GetAll = await _blogDal.GetAllAsync();
            return GetAll.OrderByDescending(x=>x.CreatedDate).Take(3);
        }

        public async Task<List<Blog>> GetListWithCategoryAsync()
        {
            return await _blogDal.GetListWithCategoryAsync();
        }

        public async Task<List<Blog>> GetListWithCategoryByWriterId(int writerId)
        {
            return await _blogDal.GetListWithCategoryByWriterId(writerId);
        }

        public async Task StatusUpdateAsync(int? id)
        {
            Blog blog = await _blogDal.GetAsync(x => x.Id == id);
            if (blog!=null)
            {
                if (blog.Status)
                {
                    blog.Status = false;
                }
                else
                {
                    blog.Status = true;
                }
                await _blogDal.UpdateAsync(blog);
            }
        }

        public async Task UpdateAsync(Blog blog)
        {
            await _blogDal.UpdateAsync(blog);
        }
    }
}
