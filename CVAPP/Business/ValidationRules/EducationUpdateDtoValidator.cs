using Entities.Concrete.DTOs.EducationDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class EducationUpdateDtoValidator : AbstractValidator<EducationUpdateDto>
    {
        public EducationUpdateDtoValidator()
        {
            RuleFor(I => I.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id alanı gereklidir");
            RuleFor(I => I.Title).NotEmpty().WithMessage("Başlık boş bırakılamaz");
            RuleFor(I => I.SubTitle).NotEmpty().WithMessage("Alt başlık boş bırakılamaz");
            RuleFor(I => I.Description).NotEmpty().WithMessage("Açıklama boş bırakılamaz");
            RuleFor(I => I.StartDate).NotEmpty().WithMessage("Başlangıç tarihi boş bırakılamaz");
        }
    }
}
