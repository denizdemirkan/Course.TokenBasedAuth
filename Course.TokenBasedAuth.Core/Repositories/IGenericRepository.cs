using Course.TokenBasedAuth.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.TokenBasedAuth.Core.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class, IEntity, new()
    {
        Task<TEntity> GetByIdAsync(int Id);
        Task<IQueryable<TEntity>> GetAllAsync();
        Task CreateAsync(TEntity entity);
        void Remove(TEntity entity);
        TEntity Update(TEntity entity);

    }
}
