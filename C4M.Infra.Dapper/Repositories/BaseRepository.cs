using C4M.Domain.Entities;
using C4M.Domain.Repositories;
using C4M.Infra.Dapper.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace C4M.Infra.Dapper.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly IDbConnection dbConn;
        protected readonly IDbTransaction dbTransaction;

        private bool isDisposed;

        protected abstract string InsertQuery { get; }
        protected abstract string InsertQueryReturnInserted { get; }
        protected abstract string UpdateByIdQuery { get; }
        protected abstract string DeleteByIdQuery { get; }
        protected abstract string SelectByIdQuery { get; }
        protected abstract string SelectAllQuery { get; }

        protected BaseRepository(IDatabaseFactory databaseOptions)
        {
            dbConn = databaseOptions.GetDbConnection;
            dbConn.Open();
        }

        protected BaseRepository(IDbConnection databaseConnection, IDbTransaction transaction = null)
        {
            dbConn = databaseConnection;
            if (dbConn.State != ConnectionState.Open)
                dbConn.Open();
            dbTransaction = transaction;
        }

        ~BaseRepository()
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (isDisposed) return;

            if (disposing)
            {
                dbConn.Close();
                dbConn.Dispose();
            }

            isDisposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual async Task<TEntity> AddAsync(TEntity obj)
        {
            TEntity entity = await dbConn.QuerySingleAsync<TEntity>(InsertQueryReturnInserted, obj, transaction: dbTransaction);
            return entity;
        }

        public virtual async Task<int> AddRangeAsync(IEnumerable<TEntity> entities)
        {
            return await dbConn.ExecuteAsync(InsertQuery, entities, transaction: dbTransaction);
        }


        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await dbConn.QueryAsync<TEntity>(SelectAllQuery, transaction: dbTransaction);
        }

        public virtual async Task<TEntity> GetByIdAsync(object id)
        {
            var entity = await dbConn.QueryAsync<TEntity>(SelectByIdQuery, new { Id = id }, transaction: dbTransaction);
            return entity.FirstOrDefault();
        }

        public virtual async Task<bool> RemoveAsync(object id)
        {
            var entity = await GetByIdAsync(id);

            if (entity == null)
                return false;

            return await RemoveAsync(entity) > 0;
        }

        public virtual async Task<int> RemoveAsync(TEntity obj)
        {
            return await dbConn.ExecuteAsync(DeleteByIdQuery, new { obj.Id }, transaction: dbTransaction);
        }

        public virtual async Task<int> RemoveRangeAsync(IEnumerable<TEntity> entities)
        {
            return await dbConn.ExecuteAsync(DeleteByIdQuery, entities.Select(obj => new { obj.Id }), transaction: dbTransaction);
        }
        public virtual async Task<int> UpdateAsync(TEntity obj)
        {
            return await dbConn.ExecuteAsync(UpdateByIdQuery, obj, transaction: dbTransaction);
        }

        public virtual async Task<int> UpdateRangeAsync(IEnumerable<TEntity> entities)
        {
            return await dbConn.ExecuteAsync(UpdateByIdQuery, entities.Select(obj => obj), transaction: dbTransaction);
        }
    }
}
