﻿using BlogSite.DataAccess.Abstract;
using BlogSite.DataAccess.Concrete.EntityFramework.Context;
using BlogSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.DataAccess.Concrete.EntityFramework
{
    public class EfWriterDal:EfEntityRepositoryBase<Writer>,IWriterDal
    {
        public EfWriterDal(BlogSiteContext context):base(context)
        {

        }
    }
}
