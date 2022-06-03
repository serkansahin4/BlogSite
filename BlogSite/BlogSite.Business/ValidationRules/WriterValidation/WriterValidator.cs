using BlogSite.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Business.ValidationRules.WriterValidation
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.Email).EmailAddress().WithMessage("Geçerli bir mail adresi giriniz.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail Adresi Boş Geçilemez.");
            RuleFor(x => x.Email).MaximumLength(100).WithMessage("Mail Adresi Maximum 100 Karakter Olmalıdır");

            RuleFor(p => p.Password).NotEmpty().WithMessage("Your password cannot be empty")
                    .MinimumLength(8).WithMessage("Your password length must be at least 8.")
                    .MaximumLength(16).WithMessage("Your password length must not exceed 16.");
                    //.Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.")
                    //.Matches(@"[a-z]+").WithMessage("Your password must contain at least one lowercase letter.")
                    //.Matches(@"[0-9]+").WithMessage("Your password must contain at least one number.")
                    //.Matches(@"[\!\?\*\.]+").WithMessage("Your password must contain at least one (!? *.).");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Ad alanı minimum 5 karakter olmalı.");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Ad alanı maximum 20 karakter olmalı. ");
        }

        
    }
}
