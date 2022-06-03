using BlogSite.Business.Abstract;
using BlogSite.Business.Concrete;
using BlogSite.DataAccess.Abstract;
using BlogSite.DataAccess.Concrete.EntityFramework;
using BlogSite.DataAccess.Concrete.EntityFramework.Context;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession();
            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                             .RequireAuthenticatedUser()
                             .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(x =>   //Authentication iþlemlerini yapacak þemayý oluþturuyoruz. Yani, 
                                  //Giriþ yapmasý için hangi sayfaya gidecek, çýkýþ yapýnca nereye gidecek,
                                  //eriþim yetkisi yoksa nereye gidecek gibi þeylerin bütününü Scheme adý
                                  //altýnda topluyoruz.
                {
                    x.LoginPath = "/Login/Index";
                    x.LogoutPath = "/Login/Index";
                    x.AccessDeniedPath = "/Error/Index";
                });

            services.AddDbContext<BlogSiteContext>(x => x.UseSqlServer(Configuration.GetConnectionString("Default")));

            services.AddTransient<IMessageService, MessageManager>();
            services.AddTransient<IMessageDal, EfMessageDal>();

            services.AddTransient<ICategoryService, CategoryManager>();
            services.AddTransient<ICategoryDal, EfCategoryDal>();

            services.AddTransient<ICommentDal, EfCommentDal>();
            services.AddTransient<ICommentService, CommentManager>();

            services.AddTransient<IBlogService, BlogManager>();
            services.AddTransient<IBlogDal, EfBlogDal>();

            services.AddTransient<IWriterService, WriterManager>();
            services.AddTransient<IWriterDal, EfWriterDal>();

            services.AddTransient<IContactService, ContactManager>();
            services.AddTransient<IContactDal, EfContactDal>();

            services.AddTransient<INotificationDal, EfNotificationDal>();
            services.AddTransient<INotificationService, NotificationManager>();

            services.AddTransient<INewsLatterDal, EfNewsLatterDal>();
            services.AddTransient<INewsLatterService, NewsLatterManager>();

            services.AddTransient<IAboutService, AboutManager>();
            services.AddTransient<IAboutDal, EfAboutDal>();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
                
            }
            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error/","?code={0}");
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute("WriterPanel", "Writer", "writer/{controller=Writer}/{action=Index}/{id?}");
                
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Category}/{action=Index}/{id?}");
            });

            

        }
    }
}
