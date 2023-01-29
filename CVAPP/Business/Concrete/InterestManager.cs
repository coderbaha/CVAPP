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
    public class InterestManager : IInterestService
    {
        private readonly IInterestRepository _interestRepository;
        public InterestManager(IInterestRepository interestRepository)
        {
            _interestRepository = interestRepository;
        }
        public void Delete(Interest entity)
        {
            _interestRepository.Delete(entity);
        }

        public List<Interest> GetAll()
        {
            return _interestRepository.GetAll();
        }

        public Interest GetById(int id)
        {
            return _interestRepository.GetById(id);
        }

        public void Insert(Interest entity)
        {
            _interestRepository.Insert(entity);
        }

        public void Update(Interest entity)
        {
            _interestRepository.Update(entity);
        }
    }
}
