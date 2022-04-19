using BlogSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.WebUI.Models.ViewModels.Register
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Lütfen bu alanı doldurunuz.")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Lütfen bu alanı doldurunuz.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Lütfen bu alanı doldurunuz.")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Lütfen bu alanı doldurunuz.")]
        [Compare("Password", ErrorMessage = "Parolanız Eşleşmedi")]
        public string PasswordConfirm { get; set; }

        [Required(ErrorMessage ="Lütfen bu alanı doldurunuz.")]
        public string ImagePath { get; set; }
        public static Writer ConvertToWriter(RegisterVM register)
        {
            return new Writer
            {
                Email = register.Email,
                Password = register.Password,
                Name = register.Name,
                Image = register.ImagePath,
                Status = true
            };
        }
    }
}
