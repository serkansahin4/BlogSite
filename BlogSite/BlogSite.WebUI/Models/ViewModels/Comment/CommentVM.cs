using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.WebUI.Models.ViewModels.Comment
{
    public class CommentVM
    {
        public string UserName { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public int BlogId { get; set; }

        public static BlogSite.Entities.Concrete.Comment ConvertToComment(CommentVM commentVM)
        {
            return new Entities.Concrete.Comment
            {
                 BlogId=commentVM.BlogId,
                  CommentTitle=commentVM.Title,
                   Content=commentVM.Content,
                    CommentUserName=commentVM.UserName,
                     CreatedDate=DateTime.Now,
                      Status=true,
            };
        }
    }
}
