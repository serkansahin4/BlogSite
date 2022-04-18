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
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public async Task AddAsync(Comment comment)
        {
            await _commentDal.InsertAsync(comment);
        }

        public Task DeleteAsync(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Comment>> GetListByBlogIdAsync(int id)
        {
            return await _commentDal.GetAllAsync(x=>x.BlogId==id);
        }

        public Task UpdateAsync(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
