using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.DTOs.SkillDtos
{
    public class SkillUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
