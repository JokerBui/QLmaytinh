using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebMayTinh.Models.Entity
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<CT_Hoa_Don> CT_Hoa_Don { get; set; }
        public virtual DbSet<CT_Phieu_Nhap> CT_Phieu_Nhap { get; set; }
        public virtual DbSet<CT_San_Pham> CT_San_Pham { get; set; }
        public virtual DbSet<Danh_Gia> Danh_Gia { get; set; }
        public virtual DbSet<Hoa_Don> Hoa_Don { get; set; }
        public virtual DbSet<Loai_TK> Loai_TK { get; set; }
        public virtual DbSet<Phieu_Nhap> Phieu_Nhap { get; set; }
        public virtual DbSet<San_Pham> San_Pham { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tai_Khoan> Tai_Khoan { get; set; }
        public virtual DbSet<Thuong_Hieu> Thuong_Hieu { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CT_Hoa_Don>()
                .Property(e => e.GhiChu)
                .IsUnicode(false);

            modelBuilder.Entity<CT_Hoa_Don>()
                .HasMany(e => e.CT_San_Pham)
                .WithRequired(e => e.CT_Hoa_Don)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CT_Phieu_Nhap>()
                .Property(e => e.GhiChu)
                .IsUnicode(false);

            modelBuilder.Entity<CT_Phieu_Nhap>()
                .HasMany(e => e.CT_San_Pham)
                .WithRequired(e => e.CT_Phieu_Nhap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Danh_Gia>()
                .Property(e => e.BinhLuan)
                .IsUnicode(false);

            modelBuilder.Entity<Hoa_Don>()
                .Property(e => e.GhiChu)
                .IsUnicode(false);

            modelBuilder.Entity<Hoa_Don>()
                .HasMany(e => e.CT_Hoa_Don)
                .WithRequired(e => e.Hoa_Don)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Loai_TK>()
                .HasMany(e => e.Tai_Khoan)
                .WithRequired(e => e.Loai_TK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phieu_Nhap>()
                .Property(e => e.GhiChu)
                .IsUnicode(false);

            modelBuilder.Entity<Phieu_Nhap>()
                .HasMany(e => e.CT_Phieu_Nhap)
                .WithRequired(e => e.Phieu_Nhap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<San_Pham>()
                .Property(e => e.MoTa)
                .IsUnicode(false);

            modelBuilder.Entity<San_Pham>()
                .Property(e => e.Anh)
                .IsUnicode(false);

            modelBuilder.Entity<San_Pham>()
                .Property(e => e.GhiChu)
                .IsUnicode(false);

            modelBuilder.Entity<San_Pham>()
                .HasMany(e => e.CT_San_Pham)
                .WithRequired(e => e.San_Pham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<San_Pham>()
                .HasMany(e => e.Danh_Gia)
                .WithRequired(e => e.San_Pham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tai_Khoan>()
                .HasMany(e => e.Danh_Gia)
                .WithRequired(e => e.Tai_Khoan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tai_Khoan>()
                .HasMany(e => e.Hoa_Don)
                .WithRequired(e => e.Tai_Khoan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tai_Khoan>()
                .HasMany(e => e.Phieu_Nhap)
                .WithRequired(e => e.Tai_Khoan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Thuong_Hieu>()
                .HasMany(e => e.San_Pham)
                .WithRequired(e => e.Thuong_Hieu)
                .WillCascadeOnDelete(false);
        }
    }
}
