using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.WebUI.Areas.Writer.Models.ViewModels.Writer
{
    public class WriterAddVM
    {
       
        [Required]
        public string Name { get; set; }
        [Required]
        public string About { get; set; }
        [Required]
        public IFormFile Image { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public bool Status { get; set; }
        
    }
}
