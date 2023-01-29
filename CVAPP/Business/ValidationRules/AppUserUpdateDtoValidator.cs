using Entities.Concrete.DTOs.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.ValidationRules
{
    public class AppUserUpdateDtoValidator : AbstractValidator<AppUserUpdateDto>
    {
        public AppUserUpdateDtoValidator()
        {

            RuleFor(I => I.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id alanı boş geçilemez");
        }
    }
}
