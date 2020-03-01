using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq;

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
        public IQueryable<TEntity> AsEnumerable()
        {
            return _context.entities;
        }

        public EntityEntry<TEntity> Add(TEntity entity)
        {
            return _context.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _context.AddRange(entities);
        }

        //public void AddRange(params object[] entities)
        //{
        //    this._context.AddRange();
        //}

        public EntityEntry<TEntity> Remove(TEntity entity)
        {
            return this._context.entities.Remove(entity);
        }
        public EntityEntry<TEntity> Update(TEntity entity)
        {
            return _context.Update(entity);
        }

        public void RemoveRange(IEnumerable<object> entities)
        {
            _context.RemoveRange(entities);
        }

        public void UpdateRange(IEnumerable<object> entities)
        {
            _context.UpdateRange(entities);
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
