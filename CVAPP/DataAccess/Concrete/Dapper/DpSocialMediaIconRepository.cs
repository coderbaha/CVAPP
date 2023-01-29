using Dapper;
using DataAccess.Interfaces;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.Dapper
{
    public class DpSocialMediaIconRepository : ISocialMediaIconRepository
    {
        private readonly IDbConnection _dbConnection;
        public DpSocialMediaIconRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public void Delete(SocialMediaIcon entity)
        {
            _dbConnection.Query<Interest>("delete SocialMediaIcons where Id=:Id", new
            {
                Id = entity.Id
            });
        }

        public List<SocialMediaIcon> GetAll()
        {
            return _dbConnection.Query<SocialMediaIcon>("select * from SocialMediaIcons").ToList();
        }

        public SocialMediaIcon GetById(int id)
        {
            return _dbConnection.QueryFirstOrDefault<SocialMediaIcon>("select * from SocialMediaIcons where Id=:Id", new
            {
                Id = id
            });
        }

        public List<SocialMediaIcon> GetByUserId(int userId)
        {
            return _dbConnection.Query<SocialMediaIcon>("select * from SocialMediaIcons where AppUserId=:id", new
            {
                id = userId
            }).ToList();
        }

        public void Insert(SocialMediaIcon entity)
        {
            _dbConnection.Query<SocialMediaIcon>("insert into SocialMediaIcons (Link,Icon,AppUserId) values(:Link,:Icon,:AppUserId)", new
            {
                Link = entity.Link,
                Icon = entity.Icon,
                AppUserId = entity.AppUserId
            });
        }

        public void Update(SocialMediaIcon entity)
        {
            _dbConnection.Query<SocialMediaIcon>("update SocialMediaIcons set Link=:Link,Icon=:Icon,AppUserId=:AppUserId where Id=:Id", new
            {
                Id=entity.Id,
                Link = entity.Link,
                Icon = entity.Icon,
                AppUserId = entity.AppUserId
            });
        }
    }
}
