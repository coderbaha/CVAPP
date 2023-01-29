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
    public class DpInterestRepository : IInterestRepository
    {
        private readonly IDbConnection _dbConnection;
        public DpInterestRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public void Delete(Interest entity)
        {
            _dbConnection.Query<Interest>("delete Interests where Id=:Id", new
            {
                Id = entity.Id
            });
        }

        public List<Interest> GetAll()
        {
            return _dbConnection.Query<Interest>("select * from Interests").ToList();
        }

        public Interest GetById(int id)
        {
            return _dbConnection.QueryFirstOrDefault<Interest>("select * from Interests where Id=:Id", new
            {
                Id = id
            });
        }

        public void Insert(Interest entity)
        {
            _dbConnection.Query<Interest>("insert into Interests (Description) values(:Description)", new
            {
                Description = entity.Description
            });
        }

        public void Update(Interest entity)
        {
            _dbConnection.Query<Interest>("update Educations set Description=:Description where Id=:Id", new
            {
                Description = entity.Description,
                Id=entity.Id
            });
        }
    }
}
