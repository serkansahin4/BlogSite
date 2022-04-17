using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.DataAccess.Abstract
{
    public interface IRepository<T> where T:class,new()
    {
        Task<List<T>> GetAllAsync(Expression<Func<T,bool>> filter=null);
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        void InsertAsync(T entity);
        void DeleteAsync(T entity);
        void UpdateAsync(T entity);
    }
}
