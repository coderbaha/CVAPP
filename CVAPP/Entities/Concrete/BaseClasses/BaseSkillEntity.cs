using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.BaseClasses
{
    public class BaseSkillEntity
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
    
}
