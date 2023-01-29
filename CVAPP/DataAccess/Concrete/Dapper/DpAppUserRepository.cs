using Dapper;
using DataAccess.Interfaces;
using Entities.Concrete;
using Entities.Concrete.DTOs.AppUserDtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Dapper
{
    public class DpAppUserRepository :IAppUserRepository
    {
        private readonly IDbConnection _dbConnection;
        public DpAppUserRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public void ChangePassword(AppUser entity)
        {
            _dbConnection.Query<AppUser>("update AppUser set password=:password where Id=:Id", new
            {
                password = entity.Password,
                Id = entity.Id
            });
        }

        public bool CheckUser(string userName, string password)
        {
            var user = _dbConnection.QueryFirstOrDefault<AppUser>("select * from AppUser where UserName=:userName and Password=:password", new
            {
                userName = userName,
                password = password
            });
            return user != null;
        }

        public void Delete(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public AppUser FindByName(string userName)
        {
            return _dbConnection.QueryFirstOrDefault<AppUser>("select * from AppUser where UserName=:userName", new { 
            userName = userName
            });
        }

        public List<AppUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public AppUser GetById(int id)
        {
            return _dbConnection.QueryFirstOrDefault<AppUser>("select * from appuser where Id=:Id", new
            {
                Id = id
            });
        }

        public void Insert(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public void Update(AppUser entity)
        {
            _dbConnection.Query<AppUser>("update AppUser set FirstName=:FirstName,LastName=:LastName,Address=:Address,Email=:Email,ImageUrl=:ImageUrl,PhoneNumber=:PhoneNumber,UserName=:UserName,ShortDescription=:ShortDescription where Id=:Id", new
            {
                Id = entity.Id,
                FirstName=entity.FirstName,
                LastName=entity.LastName,
                Address=entity.Address,
                Email=entity.Email,
                ImageUrl=entity.ImageUrl,
                PhoneNumber=entity.PhoneNumber,
                UserName=entity.UserName,
                ShortDescription=entity.ShortDescription
            });
        }

    }
}
