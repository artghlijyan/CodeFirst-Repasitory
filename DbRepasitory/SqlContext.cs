using Microsoft.EntityFrameworkCore;

namespace DbRepasitory
{
    public class SqlContext<TEntity> : DbContext where TEntity : class
    {
        internal DbSet<TEntity> entities { get; set; }
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
    }
}

