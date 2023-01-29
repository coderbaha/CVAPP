using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class SocialMediaIconManager : ISocialMediaIconService
    {
        private readonly ISocialMediaIconRepository _socialMediaIconRepository;
        public SocialMediaIconManager(ISocialMediaIconRepository socialMediaIconRepository )
        {
            _socialMediaIconRepository = socialMediaIconRepository;
        }

        public void Delete(SocialMediaIcon entity)
        {
            _socialMediaIconRepository.Delete(entity);
        }

        public List<SocialMediaIcon> GetAll()
        {
           return _socialMediaIconRepository.GetAll();
        }

        public SocialMediaIcon GetById(int id)
        {
            return _socialMediaIconRepository.GetById(id);
        }

        public List<SocialMediaIcon> GetByUserId(int userId)
        {
            return _socialMediaIconRepository.GetByUserId(userId);
        }

        public void Insert(SocialMediaIcon entity)
        {
            _socialMediaIconRepository.Insert(entity);
        }

        public void Update(SocialMediaIcon entity)
        {
            _socialMediaIconRepository.Update(entity);
        }
    }
}
