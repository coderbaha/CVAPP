using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.DTOs.InterestDtos
{
    public class InterestUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
