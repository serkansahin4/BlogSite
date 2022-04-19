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
    public class WriterManager : IWriterService
    {
        private readonly IWriterDal _writerDal;
        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }
        public async Task AddAsync(Writer writer)
        {
            await _writerDal.InsertAsync(writer);
        }

        public Task DeleteAsync(Writer writer)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Writer> GetByEmailAsync(string email)
        {
            return await _writerDal.GetAsync(x => x.Email == email);
        }

        public async Task<Writer> GetByPasswordAndEmail(string email, string password)
        {
            return await _writerDal.GetAsync(x => x.Email == email && x.Password == password);
        }

        public Task<List<Writer>> GetListByBlogIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Writer writer)
        {
            throw new NotImplementedException();
        }
    }
}
