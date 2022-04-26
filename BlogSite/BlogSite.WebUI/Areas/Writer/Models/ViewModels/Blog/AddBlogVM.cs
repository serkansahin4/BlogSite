using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.WebUI.Areas.Writer.Models.ViewModels.Blog
{
    public class AddBlogVM
    {
        public bool Status { get; private set; } = true;
        public DateTime CreatedDate { get; private set; } = DateTime.Now;
        public int WriterId { get; set; } = 1;
        public string CategoryId { get; set; }
        public string Content { get; set; }
        
        public string BlogImage { get; set; }
        public string Title { get; set; }
        public static BlogSite.Entities.Concrete.Blog ConvertToBlog(AddBlogVM addBlogVM)
        {
            return new BlogSite.Entities.Concrete.Blog
            {
                Status = addBlogVM.Status,
                CreatedDate = addBlogVM.CreatedDate,
                WriterId = addBlogVM.WriterId,
                CategoryId = Convert.ToInt32(addBlogVM.CategoryId),
                Title = addBlogVM.Title,
                Content = addBlogVM.Content,
                BlogImage = "web/images/"+addBlogVM.BlogImage,
                BlogThumbnailImage = "web/images/"+addBlogVM.BlogImage,
            };
        }
    }
}
