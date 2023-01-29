using Dapper.Contrib.Extensions;
using Dapper;
using DataAccess.Interfaces;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Concrete.Dapper
{
    public class DpGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, ITable, new()
    {
        private readonly IDbConnection _dbConnection;
        public DpGenericRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public void Delete(TEntity entity)
        {
            _dbConnection.Delete(entity);
        }

        public List<TEntity> GetAll()
        {
            return _dbConnection.GetAll<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            //return _dbConnection.QueryFirstOrDefault<TEntity>("select * from " + typeof(TEntity).Name + " where Id=:Id", new
            //{
            //    Id = id
            //});
            return _dbConnection.Get<TEntity>(id);
        }
        public void Insert(TEntity entity)
        {
            _dbConnection.Insert(entity);
        }

        public void Update(TEntity entity)
        {
            _dbConnection.Update(entity);
        }
    }
}
