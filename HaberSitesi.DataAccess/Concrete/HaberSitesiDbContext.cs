using HaberSitesi.Entities.Concrete;
using HaberSitesi.Entities.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberSitesi.DataAccess.Concrete
{
    public class HaberSitesiDbContext:DbContext
    {
        private const string ConnectionString = @"Server=DESKTOP-SL1S3RQ\SQLEXPRESS;Database=DboHaberSitesi;Trusted_Connection=True;MultipleActiveResultSets=true";

        public HaberSitesiDbContext(DbContextOptions<HaberSitesiDbContext> options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Editor> Editor { get; set; }
        public DbSet<Haber> Haber { get; set; }
        public DbSet<Yazar> Yazar { get; set; }
        public DbSet<Yazi> Yazi { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Hesaplar> Hesaplar { get; set; }
        public DbSet<HesapHareketleri> HesapHareketleri { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Relationships
            modelBuilder.Entity<Editor>().HasMany(c => c.Haberleri).WithOne(c => c.Editoru).HasForeignKey(c => c.EditorId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Yazar>().HasMany(c => c.Yazilari).WithOne(c => c.Yazari).HasForeignKey(c => c.YazarId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Kategori>().HasMany(c => c.Haberleri).WithOne(c => c.Kategorisi).HasForeignKey(c => c.KategoriId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Haber>().HasMany(c => c.Yorumlar).WithOne(c => c.Haberi).HasForeignKey(c => c.HaberId).OnDelete(DeleteBehavior.Cascade);

            //Mapping
            modelBuilder.ApplyConfiguration(new EditorMap());
            modelBuilder.ApplyConfiguration(new HaberMap());
            modelBuilder.ApplyConfiguration(new YazarMap());
            modelBuilder.ApplyConfiguration(new YaziMap());
            modelBuilder.ApplyConfiguration(new KategoriMap());
            modelBuilder.ApplyConfiguration(new YorumMap());
        }
    }
}
