using Entities.Concrete.DTOs.ExperienceDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class ExperienceAddDtoValidator : AbstractValidator<ExperienceAddDto>
    {
        public ExperienceAddDtoValidator()
        {
            RuleFor(I => I.Title).NotEmpty().WithMessage("Başlık boş bırakılamaz");
            RuleFor(I => I.SubTitle).NotEmpty().WithMessage("Alt başlık boş bırakılamaz");
            RuleFor(I => I.StartDate).NotEmpty().WithMessage("Başlangıç tarihi boş bırakılamaz");
            RuleFor(I => I.Description).NotEmpty().WithMessage("Açıklama boş bırakılamaz");
        }
    }
}
