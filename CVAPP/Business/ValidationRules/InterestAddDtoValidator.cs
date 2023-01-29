using Entities.Concrete.DTOs.InterestDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class InterestAddDtoValidator : AbstractValidator<InterestAddDto>
    {
        public InterestAddDtoValidator()
        {
            RuleFor(I => I.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
        }
    }
}
