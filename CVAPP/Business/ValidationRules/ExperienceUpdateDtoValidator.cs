using Entities.Concrete.DTOs.ExperienceDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class ExperienceUpdateDtoValidator : AbstractValidator<ExperienceUpdateDto>
    {
        public ExperienceUpdateDtoValidator()
        {
            RuleFor(I => I.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id boş bırakılamaz");
        }
    }
}
