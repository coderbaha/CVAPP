using Dapper;
using DataAccess.Interfaces;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Dapper
{
    public class DpExperienceRepository : IExperienceRepository
    {
        private readonly IDbConnection _dbConnection;
        public DpExperienceRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public void Delete(Experience entity)
        {
            _dbConnection.Query<Experience>("delete Experiences where Id=:Id", new
            {
                Id = entity.Id
            });
        }

        public List<Experience> GetAll()
        {
            return _dbConnection.Query<Experience>("select * from Experiences").ToList();
        }

        public Experience GetById(int id)
        {
            return _dbConnection.QueryFirstOrDefault<Experience>("select * from Experiences where Id=:Id", new
            {
                Id = id
            });
        }

        public void Insert(Experience entity)
        {
            _dbConnection.Query<Experience>("insert into Experiences (Title,SubTitle,Description,StartDate,EndDate) values(:Title,:SubTitle,:Description,:StartDate,:EndDate)", new
            {
                Title = entity.Title,
                Subtitle = entity.SubTitle,
                Description = entity.Description,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate
            });
        }

        public void Update(Experience entity)
        {
            _dbConnection.Query<Experience>("update Experiences set Title=:Title,SubTitle=:SubTitle,Description=:Description,StartDate=:StartDate,EndDate=:EndDate where Id=:Id", new
            {
                Id = entity.Id,
                Title = entity.Title,
                Subtitle = entity.SubTitle,
                Description = entity.Description,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate
            });
        }
    }
}
