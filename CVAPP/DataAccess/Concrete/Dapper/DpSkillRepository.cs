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
    public class DpSkillRepository : ISkillRepository
    {
        private readonly IDbConnection _dbConnection;
        public DpSkillRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public void Delete(Skill entity)
        {
            _dbConnection.Query<Skill>("delete Skills where Id=:Id", new
            {
                Id = entity.Id
            });
        }

        public List<Skill> GetAll()
        {
            return _dbConnection.Query<Skill>("select * from Skills").ToList();
        }

        public Skill GetById(int id)
        {
            return _dbConnection.QueryFirstOrDefault<Skill>("select * from Skills where Id=:Id", new
            {
                Id = id
            });
        }

        public void Insert(Skill entity)
        {
            _dbConnection.Query<Skill>("insert into Skills (Description) values(:Description)", new
            {
                Description = entity.Description
            });
        }

        public void Update(Skill entity)
        {
            _dbConnection.Query<Skill>("update Skills set Description=:Description where Id=:Id", new
            {
                Description = entity.Description,
                Id = entity.Id
            });
        }
    }
}
