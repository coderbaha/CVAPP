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
    public class EducationManager : IEducationService
    {
        private readonly IEducationRepository _educationRepository;
        public EducationManager(IEducationRepository educationRepository)
        {
            _educationRepository = educationRepository;
        }
        public void Delete(Education entity)
        {
            _educationRepository.Delete(entity);
        }

        public List<Education> GetAll()
        {
            return _educationRepository.GetAll();
        }

        public Education GetById(int id)
        {
            return _educationRepository.GetById(id);
        }

        public void Insert(Education entity)
        {
            _educationRepository.Insert(entity);
        }

        public void Update(Education entity)
        {
            _educationRepository.Update(entity);
        }
    }
}
