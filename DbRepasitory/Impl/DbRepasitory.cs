using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;

namespace DbRepasitory.Repasitories.Impl
{
    public class DbRepasitory<TEntity> : IRepasitory<TEntity>, IDisposable
        where TEntity : class, new()
    {
        private readonly SqlContext<TEntity> _context;

        public DbRepasitory(string conString)
        {
            this._context = new SqlContext<TEntity>(conString);
        }

        public IEnumerable<TEntity> SelectAll()
        {
            return null;
        }

        public EntityEntry<TEntity> Add(TEntity entity)
        {
            return _context.entities.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _context.entities.AddRange(entities);
        }

        public DbSet<TEntity> AsEnumerable()
        {
            return _context.entities;
        }

        public void AddRange(params object[] entities)
        {
            this.AddRange(entities);
        }

        public int Update(TEntity entity)
        {
            return 0;
        }

        public EntityEntry<TEntity> Remove(TEntity entity)
        {
            return this._context.entities.Remove(entity);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        #region Disposing

        bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                _context.Dispose();
            }

            disposed = true;
        }

        ~DbRepasitory()
        {
            Dispose(false);
        }

        #endregion
    }
}
