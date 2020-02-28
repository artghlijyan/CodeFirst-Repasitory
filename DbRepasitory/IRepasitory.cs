using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;

namespace DbRepasitory
{
    public interface IRepasitory<TEntity> where TEntity : class, new()
    {
        EntityEntry<TEntity> Add(TEntity model);

        void AddRange(IEnumerable<TEntity> entities);

        void AddRange(params object[] entities);

        int SaveChanges();
    }
}