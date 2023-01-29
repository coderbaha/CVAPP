using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        private readonly IExperienceRepository _experienceRepository;
        public ExperienceManager(IExperienceRepository experienceRepository)
        {
            _experienceRepository = experienceRepository;
        }
        public void Delete(Experience entity)
        {
            _experienceRepository.Delete(entity);
        }

        public List<Experience> GetAll()
        {
            return _experienceRepository.GetAll();
        }

        public Experience GetById(int id)
        {
            return _experienceRepository.GetById(id);
        }

        public void Insert(Experience entity)
        {
            _experienceRepository.Insert(entity);
        }

        public void Update(Experience entity)
        {
            _experienceRepository.Update(entity);
        }
    }
}
