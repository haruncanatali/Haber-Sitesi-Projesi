using HaberSitesi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberSitesi.Entities.Mapping
{
    public class YaziMap : IEntityTypeConfiguration<Yazi>
    {
        public void Configure(EntityTypeBuilder<Yazi> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();

            builder.Property(c => c.YaziBasligi).HasMaxLength(250).IsRequired();
            builder.Property(c => c.YaziIcerigi).HasMaxLength(5000).IsRequired();
            builder.Property(c => c.YaziResimUrl).HasMaxLength(500).IsRequired();
            builder.Property(c => c.YaziTarihi).IsRequired();
            builder.Property(c => c.YazarId).IsRequired();

            builder.ToTable("Yazilar");
            builder.Property(c => c.Id).HasColumnName("Id");
            builder.Property(c => c.YaziBasligi).HasColumnName("YaziBasligi");
            builder.Property(c => c.YaziIcerigi).HasColumnName("YaziIcerigi");
            builder.Property(c => c.YaziResimUrl).HasColumnName("YaziResimUrl");
            builder.Property(c => c.YaziTarihi).HasColumnName("YaziTarihi");
            builder.Property(c => c.YazarId).HasColumnName("YazarId");
        }
    }
}
