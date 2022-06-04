using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Entities.Concrete
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public int? SenderWriterId { get; set; }
        public int? ReceiverWriterId { get; set; }
        public string Subject { get; set; }
        public string Details { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public Writer SenderWriter { get; set; }
        public Writer ReceiverWriter { get; set; }
    }
}
