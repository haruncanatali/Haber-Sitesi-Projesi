using HaberSitesi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberSitesi.Entities.Mapping
{
    public class HaberMap : IEntityTypeConfiguration<Haber>
    {
        public void Configure(EntityTypeBuilder<Haber> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();

            builder.Property(c => c.HaberBasligi).HasMaxLength(250).IsRequired();
            builder.Property(c => c.HaberAnaResimUrl).HasMaxLength(500).IsRequired();
            builder.Property(c => c.HaberIcerik).HasMaxLength(5000).IsRequired();
            builder.Property(c => c.EditorId).IsRequired();
            builder.Property(c => c.HaberTarihi).IsRequired();
            builder.Property(c => c.KategoriId).IsRequired();

            builder.ToTable("Haberler");
            builder.Property(c => c.HaberTarihi).HasColumnName("HaberTarihi");
            builder.Property(c => c.Id).HasColumnName("Id");
            builder.Property(c => c.HaberBasligi).HasColumnName("HaberBasligi");
            builder.Property(c => c.HaberAnaResimUrl).HasColumnName("HaberAnaResimUrl");
            builder.Property(c => c.HaberIcerik).HasColumnName("HaberIcerik");
            builder.Property(c => c.EditorId).HasColumnName("EditorId");
            builder.Property(c => c.KategoriId).HasColumnName("KategoriId");
        }
    }
}
