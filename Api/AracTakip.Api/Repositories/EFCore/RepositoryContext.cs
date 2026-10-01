using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Repositories.EFCore
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }

        // DbSet'ler buraya

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Config klasöründeki IEntityTypeConfiguration sınıflarını otomatik uygular
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
