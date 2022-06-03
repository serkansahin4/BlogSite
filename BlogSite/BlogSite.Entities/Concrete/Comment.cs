using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Entities.Concrete
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string CommentUserName { get; set; }
        public string Content { get; set; }
        public string CommentTitle { get; set; }
        public DateTime CreatedDate { get; set; }
        public int BlogPoint { get; set; }
        public bool Status { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
