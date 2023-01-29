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
    public class DpCertificationRepository: ICertificationRepository
    {
        private readonly IDbConnection _dbConnection;
        public DpCertificationRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public void Delete(Certification entity)
        {
            _dbConnection.Query<Certification>("delete Certifications where Id=:Id", new
            {
                Id=entity.Id
            });
        }

        public List<Certification> GetAll()
        {
            return _dbConnection.Query<Certification>("select * from Certifications").ToList();
        }

        public Certification GetById(int id)
        {
            return _dbConnection.QueryFirstOrDefault<Certification>("select * from Certifications where Id=:Id", new
            {
                Id = id
            });
        }

        public void Insert(Certification entity)
        {
            _dbConnection.Query<Certification>("insert into Certifications (Description) values(:Description)", new
            {
                Description = entity.Description
            });
        }

        public void Update(Certification entity)
        {
            _dbConnection.Query<Certification>("update Certifications set Description=:Description where Id=:Id", new
            {
                Id = entity.Id,
                Description = entity.Description
            });
        }
    }
}
