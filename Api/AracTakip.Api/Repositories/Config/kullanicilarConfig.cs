using Entities.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Config
{
    public class kullanicilarConfig : IEntityTypeConfiguration<kullanicilar>
    {
        public void Configure(EntityTypeBuilder<kullanicilar> builder)
        {
            builder.ToTable("kullanicilar");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Email).IsRequired().HasMaxLength(150);
            builder.HasIndex(x => x.Email).IsUnique();

            builder.Property(x => x.PasswordHash).IsRequired().HasMaxLength(100);

            builder.Property(x => x.Ad).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Soyad).IsRequired().HasMaxLength(50);

            builder.Property(x => x.Telefon).HasMaxLength(20);

            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");
        }
    }
}
