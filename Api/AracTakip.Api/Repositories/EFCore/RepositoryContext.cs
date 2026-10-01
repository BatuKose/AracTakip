using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Repositories.EFCore
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }

        public DbSet<kullanicilar>Kullanicilar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
           .SelectMany(e => e.GetProperties())
           .Where(p => p.ClrType == typeof(DateTime) || p.ClrType == typeof(DateTime?)))
            {
                property.SetColumnType("datetime");
            }

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
