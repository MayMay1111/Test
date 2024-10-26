using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLCHDT.Model
{
    public partial class GiaoHangDB : DbContext
    {
        public GiaoHangDB()
            : base("name=GiaoHangDB")
        {
        }

        public virtual DbSet<ChiTietGiaoHang> ChiTietGiaoHangs { get; set; }
        public virtual DbSet<GiaoHang> GiaoHangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietGiaoHang>()
                .Property(e => e.MaGiaoHang)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietGiaoHang>()
                .Property(e => e.MaSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<GiaoHang>()
                .Property(e => e.MaGiaoHang)
                .IsUnicode(false);

            modelBuilder.Entity<GiaoHang>()
                .Property(e => e.MaHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<GiaoHang>()
                .Property(e => e.NhanVienGiao)
                .IsUnicode(false);
        }
    }
}
