using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DTOs.CertificationDtos
{
    public class CertificationAddDto : IDto
    {
        public string Description { get; set; }
    }
}
