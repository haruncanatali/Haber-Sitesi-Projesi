using HaberSitesi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberSitesi.Entities.Mapping
{
    public class EditorMap : IEntityTypeConfiguration<Editor>
    {
        public void Configure(EntityTypeBuilder<Editor> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();

            builder.Property(c => c.EditorAdi).HasMaxLength(50).IsRequired();
            builder.Property(c => c.EditorSoyadi).HasMaxLength(50).IsRequired();

            builder.ToTable("Editorler");
            builder.Property(c => c.Id).HasColumnName("Id");
            builder.Property(c => c.EditorAdi).HasColumnName("EditorAdi");
            builder.Property(c => c.EditorSoyadi).HasColumnName("EditorSoyadi");
        }
    }
}
