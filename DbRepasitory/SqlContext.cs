using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DbRepasitory
{
    class SqlContext<TEntity> : DbContext where TEntity : class
    {
        internal DbSet<TEntity> entities;
        string _conString;

        public SqlContext(string conString)
        {
            this._conString = conString;
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this._conString);
        }

        public void Do()
        {
            var entityList = entities.ToList();
        }
    }
}

