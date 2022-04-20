using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.WebUI.Models.ViewModels.Contact
{
    public class ContactAddVM
    {
        public ContactAddVM()
        {
            CreatedDate = DateTime.Now;
            Status = true;
        }
        public string ContactUserName { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; private set; }
        public bool Status { get; private set; }

        public static BlogSite.Entities.Concrete.Contact ConvertToContact(ContactAddVM contactAddVM)
        {
            return new Entities.Concrete.Contact
            {
                 ContactUserName=contactAddVM.ContactUserName,
                  Mail=contactAddVM.Mail,
                   Message=contactAddVM.Message,
                    Subject=contactAddVM.Subject,
            };
        }
    }
}
