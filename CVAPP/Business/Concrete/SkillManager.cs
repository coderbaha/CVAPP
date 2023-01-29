using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SkillManager : ISkillService
    {
        private readonly ISkillRepository _skillRepository;
        public SkillManager(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }
        public void Delete(Skill entity)
        {
            _skillRepository.Delete(entity);
        }

        public List<Skill> GetAll()
        {
            return _skillRepository.GetAll();
        }

        public Skill GetById(int id)
        {
            return _skillRepository.GetById(id);
        }

        public void Insert(Skill entity)
        {
            _skillRepository.Insert(entity);
        }

        public void Update(Skill entity)
        {
            _skillRepository.Update(entity);
        }
    }
}
