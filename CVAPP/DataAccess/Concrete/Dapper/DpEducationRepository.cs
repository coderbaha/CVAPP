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
    public class DpEducationRepository : IEducationRepository
    {
        private readonly IDbConnection _dbConnection;
        public DpEducationRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public void Delete(Education entity)
        {
            _dbConnection.Query<Education>("delete Educations where Id=:Id", new
            {
                Id = entity.Id
            });
        }

        public List<Education> GetAll()
        {
            return _dbConnection.Query<Education>("select * from Educations").ToList();
        }

        public Education GetById(int id)
        {
            return _dbConnection.QueryFirstOrDefault<Education>("select * from Educations where Id=:Id", new
            {
                Id = id
            });
        }

        public void Insert(Education entity)
        {
            _dbConnection.Query<Education>("insert into Educations (Title,SubTitle,Description,StartDate,EndDate) values(:Title,:SubTitle,:Description,:StartDate,:EndDate)", new
            {
                Title = entity.Title,
                Subtitle = entity.SubTitle,
                Description = entity.Description,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate
            });
        }

        public void Update(Education entity)
        {
            _dbConnection.Query<Education>("update Educations set Title=:Title,SubTitle=:SubTitle,Description=:Description,StartDate=:StartDate,EndDate=:EndDate where Id=:Id", new
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
