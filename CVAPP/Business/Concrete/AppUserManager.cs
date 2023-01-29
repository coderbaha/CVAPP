using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.Concrete;
using Entities.Concrete.DTOs.AppUserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserRepository _appUserRepository;
        public AppUserManager(IAppUserRepository appUserRepository)
        {
            _appUserRepository = appUserRepository;
        }

        public void ChangePassword(AppUser entity)
        {
            _appUserRepository.ChangePassword(entity);
        }

        public bool CheckUser(string userName, string password)
        {
            return _appUserRepository.CheckUser(userName, password);
        }

        public void Delete(AppUser entity)
        {
            _appUserRepository.Delete(entity);
        }

        public AppUser FindByName(string userName)
        {
            return _appUserRepository.FindByName(userName);
        }

        public List<AppUser> GetAll()
        {
            return _appUserRepository.GetAll();
        }

        public AppUser GetById(int id)
        {
            return _appUserRepository.GetById(id);
        }

        public void Insert(AppUser entity)
        {
            _appUserRepository.Insert(entity);
        }

        public void Update(AppUser entity)
        {
            _appUserRepository.Update(entity);
        }
    }
}
