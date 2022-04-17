﻿using BlogSite.Business.Abstract;
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

        public async Task UpdateAsync(Blog blog)
        {
            await _blogDal.UpdateAsync(blog);
        }
    }
}