using System.Collections.Generic;
using System;

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

        public void Add(TEntity entity)
        {
            _context.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _context.AddRange(entities);
        }

        public IEnumerable<TEntity> AsEnumerable()
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

        public bool Delete(int id)
        {
            return false;
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
