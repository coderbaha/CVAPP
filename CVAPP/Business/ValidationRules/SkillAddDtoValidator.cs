using Entities.Concrete.DTOs.SkillDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class SkillAddDtoValidator : AbstractValidator<SkillAddDto>
    {
        public SkillAddDtoValidator()
        {
            RuleFor(I => I.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
        }
    }
}
