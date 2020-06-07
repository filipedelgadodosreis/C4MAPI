using C4M.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C4M.Domain.Repositories
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : BaseEntity
    {
        Task<TEntity> AddAsync(TEntity obj);
        Task<int> AddRangeAsync(IEnumerable<TEntity> entities);

        Task<TEntity> GetByIdAsync(object id);
        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<int> UpdateAsync(TEntity obj);
        Task<int> UpdateRangeAsync(IEnumerable<TEntity> entities);

        Task<bool> RemoveAsync(object id);
        Task<int> RemoveAsync(TEntity obj);
        Task<int> RemoveRangeAsync(IEnumerable<TEntity> entities);
    }
}
