using HaberSitesi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberSitesi.Entities.Mapping
{
    public class YorumMap:IEntityTypeConfiguration<Yorum>
    {
        public void Configure(EntityTypeBuilder<Yorum> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn().HasColumnName("Id");

            builder.Property(c => c.Ad).HasMaxLength(50).IsRequired().HasColumnName("Ad");
            builder.Property(c => c.Soyad).HasMaxLength(50).IsRequired().HasColumnName("Soyad");
            builder.Property(c => c.Mesaj).HasMaxLength(1500).IsRequired().HasColumnName("Mesaj");
            builder.Property(c => c.YorumTarihi).IsRequired().HasColumnName("YorumTarihi");
            builder.Property(c => c.HaberId).IsRequired().HasColumnName("HaberId");

            builder.ToTable("Yorumlar");
        }
    }
}
