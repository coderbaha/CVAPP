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
    public class CertificationManager : ICertificationService
    {
        private readonly ICertificationRepository _certificationRepository;
        public CertificationManager(ICertificationRepository certificationRepository)
        {
            _certificationRepository = certificationRepository;
        }
        public void Delete(Certification entity)
        {
            _certificationRepository.Delete(entity);
        }

        public List<Certification> GetAll()
        {
            return _certificationRepository.GetAll();
        }

        public Certification GetById(int id)
        {
            return _certificationRepository.GetById(id);
        }

        public void Insert(Certification entity)
        {
            _certificationRepository.Insert(entity);
        }

        public void Update(Certification entity)
        {
            _certificationRepository.Update(entity);
        }
    }
}
