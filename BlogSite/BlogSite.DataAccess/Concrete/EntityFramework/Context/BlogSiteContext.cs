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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Writer>().HasMany(x => x.SenderMessages).WithOne(x => x.SenderWriter).HasForeignKey(x => x.SenderWriterId).OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<Writer>().HasMany(x => x.ReceiveMessages).WithOne(x => x.ReceiverWriter).HasForeignKey(x => x.ReceiverWriterId).OnDelete(DeleteBehavior.ClientSetNull);

            base.OnModelCreating(modelBuilder);
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
