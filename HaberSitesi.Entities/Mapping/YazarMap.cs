using HaberSitesi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberSitesi.Entities.Mapping
{
    public class YazarMap : IEntityTypeConfiguration<Yazar>
    {
        public void Configure(EntityTypeBuilder<Yazar> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();

            builder.Property(c => c.YazarAdi).HasMaxLength(50).IsRequired();
            builder.Property(c => c.YazarSoyadi).HasMaxLength(50).IsRequired();
            builder.Property(c => c.YazarBiyografisi).HasMaxLength(5000).IsRequired();
            builder.Property(c => c.YazarFotoUrl).HasMaxLength(500).IsRequired();

            builder.ToTable("Yazarlar");
            builder.Property(c => c.Id).HasColumnName("Id");
            builder.Property(c => c.YazarAdi).HasColumnName("YazarAdi");
            builder.Property(c => c.YazarSoyadi).HasColumnName("YazarSoyadi");
            builder.Property(c => c.YazarBiyografisi).HasColumnName("YazarBiyografisi");
            builder.Property(c => c.YazarFotoUrl).HasColumnName("YazarFotoUrl");
        }
    }
}
