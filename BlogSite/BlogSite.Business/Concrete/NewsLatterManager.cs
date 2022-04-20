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
    public class NewsLatterManager : INewsLatterService
    {
        private readonly INewsLatterDal _newsLatterDal;
        public NewsLatterManager(INewsLatterDal newsLatterDal)
        {
            _newsLatterDal = newsLatterDal;
        }
        public async Task AddNewsLatterAsync(NewsLatter newsLatter)
        {
            await _newsLatterDal.InsertAsync(newsLatter);
        }
    }
}
