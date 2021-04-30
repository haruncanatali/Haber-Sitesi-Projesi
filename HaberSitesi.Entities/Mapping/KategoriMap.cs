using HaberSitesi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberSitesi.Entities.Mapping
{
    public class KategoriMap : IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();

            builder.Property(c => c.KategoriAdi).HasMaxLength(50).IsRequired();

            builder.ToTable("Kategoriler");
            builder.Property(c => c.Id).HasColumnName("Id");
            builder.Property(c => c.KategoriAdi).HasColumnName("KategoriAdi");
        }
    }
}
