using Entities.Concrete.DTOs.SocialMediaIconDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class SocialMediaIconUpdateDtoValidator : AbstractValidator<SocialMediaIconUpdateDto>
    {
        public SocialMediaIconUpdateDtoValidator()
        {
            RuleFor(I => I.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id boş bırakılamaz");
        }
    }
}
