using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.DTOs.InterestDtos
{
    public class InterestAddDto : IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
