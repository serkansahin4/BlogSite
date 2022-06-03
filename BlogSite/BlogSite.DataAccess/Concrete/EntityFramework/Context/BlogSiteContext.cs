using BlogSite.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.DataAccess.Concrete.EntityFramework.Context
{
    public class BlogSiteContext:DbContext
    {
        public BlogSiteContext(DbContextOptions<BlogSiteContext> db):base(db)
        {

        }
        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Writer> Writers { get; set; }
        public virtual DbSet<NewsLatter> NewsLatters { get; set; }
        public virtual DbSet<BlogRayting> BlogRaytings { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Message> Messages{ get; set; }
    }
}
