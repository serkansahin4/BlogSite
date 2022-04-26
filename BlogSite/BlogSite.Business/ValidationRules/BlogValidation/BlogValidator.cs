using BlogSite.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Business.ValidationRules.BlogValidation
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Blog Başlığı Boş Geçilemez");
            RuleFor(x => x.Content).NotEmpty().WithMessage("İçeriği Boş Geçemezsiniz.");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Resim Alanı Boş Geçilemez.");
            RuleFor(x => x.Title).MaximumLength(150).WithMessage("Maximum 150 karakter girebilirsiniz.");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Minimum 5 Karakter Girebilirsiniz.");
        }
    }
}
