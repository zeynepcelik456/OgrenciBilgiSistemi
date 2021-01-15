using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace OgrData.Models
{
    public partial class DbOgrSistemContext : DbContext
    {
        public DbOgrSistemContext()
        {
        }

        public DbOgrSistemContext(DbContextOptions<DbOgrSistemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAdmin> TblAdmins { get; set; }
        public virtual DbSet<TblBolum> TblBolums { get; set; }
        public virtual DbSet<TblDer> TblDers { get; set; }
        public virtual DbSet<TblDuyuru> TblDuyurus { get; set; }
        public virtual DbSet<TblHarc> TblHarcs { get; set; }
        public virtual DbSet<TblLogin> TblLogins { get; set; }
        public virtual DbSet<TblOgrenciDer> TblOgrenciDers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-DNNFR5;Database=DbOgrSistem;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<TblAdmin>(entity =>
            {
                entity.ToTable("TblAdmin");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdminAdı).HasMaxLength(30);

                entity.Property(e => e.AdminPasword).HasMaxLength(30);

                entity.Property(e => e.AdminSoyadı).HasMaxLength(30);

                entity.Property(e => e.AdminUserName).HasMaxLength(30);
            });

            modelBuilder.Entity<TblBolum>(entity =>
            {
                entity.ToTable("TblBolum");

                entity.Property(e => e.BolumAcıklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bolumAcıklama");

                entity.Property(e => e.BolumAdı)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("bolumAdı");

                entity.Property(e => e.BolumEposta)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("bolumEposta");
            });

            modelBuilder.Entity<TblDer>(entity =>
            {
                entity.HasKey(e => e.ıd);

                entity.Property(e => e.DersAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dersAdi");

                entity.Property(e => e.DersKodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dersKodu");

                entity.Property(e => e.DersKredi).HasColumnName("dersKredi");

                entity.HasOne(d => d.BolumNavigation)
                    .WithMany(p => p.TblDers)
                    .HasForeignKey(d => d.Bolum)
                    .HasConstraintName("FK_TblDers_TblBolum");
            });

            modelBuilder.Entity<TblDuyuru>(entity =>
            {
                entity.ToTable("TblDuyuru");

                entity.Property(e => e.Baslık)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.İcerik)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblHarc>(entity =>
            {
                entity.HasKey(e => e.ıd);

                entity.ToTable("TblHarc");

                entity.Property(e => e.Durum)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.OgrenciNavigation)
                    .WithMany(p => p.TblHarcs)
                    .HasForeignKey(d => d.Ogrenci)
                    .HasConstraintName("FK_TblHarc_tblLogin");
            });

            modelBuilder.Entity<TblLogin>(entity =>
            {
                entity.ToTable("tblLogin");

                entity.Property(e => e.OgrAd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ogrAd");

                entity.Property(e => e.OgrSoyad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OkulNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("okulNo");

                entity.Property(e => e.Sıfre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sıfre");

                entity.HasOne(d => d.OgrBolumNavigation)
                    .WithMany(p => p.TblLogins)
                    .HasForeignKey(d => d.OgrBolum)
                    .HasConstraintName("FK_tblLogin_TblBolum");
            });

            modelBuilder.Entity<TblOgrenciDer>(entity =>
            {
                entity.HasKey(e => e.ıd);

                entity.Property(e => e.Final).HasColumnName("final");

                entity.HasOne(d => d.DersNavigation)
                    .WithMany(p => p.TblOgrenciDers)
                    .HasForeignKey(d => d.Ders)
                    .HasConstraintName("FK_TblOgrenciDers_TblDers");

                entity.HasOne(d => d.OgrenciNavigation)
                    .WithMany(p => p.TblOgrenciDers)
                    .HasForeignKey(d => d.Ogrenci)
                    .HasConstraintName("FK_TblOgrenciDers_tblLogin");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
