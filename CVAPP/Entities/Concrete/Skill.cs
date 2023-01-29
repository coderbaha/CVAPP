using Entities.Concrete.BaseClasses;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [Dapper.Contrib.Extensions.Table("Skills")]
    public class Skill : BaseSkillEntity,ITable
    {
    }
}
