using ApiRest.Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace RestAPI.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("dt_cadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("dt_cadastro").CurrentValue = System.DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("dt_cadastro").IsModified = false;

                }
            }
            return base.SaveChanges();
        }

    }
}
