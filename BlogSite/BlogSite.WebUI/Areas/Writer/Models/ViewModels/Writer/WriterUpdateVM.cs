using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.WebUI.Areas.Writer.Models.ViewModels.Writer
{
    public class WriterUpdateVM
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string About { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password",ErrorMessage ="Parola Eşleşmedi.")]
        public string PasswordConfirm { get; set; }
        public static BlogSite.Entities.Concrete.Writer ConvertToWriter(WriterUpdateVM writerUpdateVM)
        {
            return new Entities.Concrete.Writer
            {
                Email = writerUpdateVM.Email,
                About = writerUpdateVM.About,
                Name = writerUpdateVM.Name,
                Image = writerUpdateVM.Image,
                Password = writerUpdateVM.Password,
                Id = writerUpdateVM.Id,
                Status=true,

            };
        }
    }
}
