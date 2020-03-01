using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Linq;

namespace DbRepasitory
{
    public interface IRepasitory<TEntity> where TEntity : class, new()
    {
        IQueryable<TEntity> AsEnumerable();

        EntityEntry<TEntity> Add(TEntity model);

        void AddRange(IEnumerable<TEntity> entities);

        //void AddRange(params object[] entities); params[]-ov chi ashxatum
        EntityEntry<TEntity> Remove(TEntity entity);

        void RemoveRange(IEnumerable<object> entities);

        EntityEntry<TEntity> Update(TEntity entity);

        void UpdateRange(IEnumerable<object> entities);

        int SaveChanges();
    }
}