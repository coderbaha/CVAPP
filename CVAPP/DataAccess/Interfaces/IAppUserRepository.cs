using Entities.Concrete;
using Entities.Concrete.DTOs.AppUserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IAppUserRepository : IGenericRepository<AppUser>
    {
        /// <summary>
        /// User var ise true , yok ise false döner
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool CheckUser(string userName, string password);
        AppUser FindByName(string userName);
        void ChangePassword(AppUser entity);
    }
}
