using Entities.Concrete.DTOs.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class AppUserPasswordDtoValidator : AbstractValidator<AppUserPasswordDto>
    {
        public AppUserPasswordDtoValidator()
        {
            RuleFor(I => I.Password).NotEmpty().WithMessage("Parola boş geçilemez");
            RuleFor(I => I.ConfirmPassword).NotEmpty().WithMessage("Parola tekrar boş geçilemez");
            RuleFor(I => I.ConfirmPassword).Equal(I => I.Password).WithMessage("Parolalar uyuşmuyor");
        }
    }
}
