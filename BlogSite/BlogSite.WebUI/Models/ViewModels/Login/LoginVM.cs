using BlogSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.WebUI.Models.ViewModels.Login
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Boş Geçilemez.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez.")]
        public string Password { get; set; }

    }
}
