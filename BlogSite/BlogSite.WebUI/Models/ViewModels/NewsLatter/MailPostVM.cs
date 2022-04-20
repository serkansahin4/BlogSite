using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.WebUI.Models.ViewModels.NewsLatter
{
    public class MailPostVM
    {
        public string Email { get; set; }

        public static BlogSite.Entities.Concrete.NewsLatter ConvertToNewsLatter(MailPostVM mailPostVM)
        {
            return new BlogSite.Entities.Concrete.NewsLatter
            {
                Mail = mailPostVM.Email,
                 Status=true
            };
        }
    }
}
