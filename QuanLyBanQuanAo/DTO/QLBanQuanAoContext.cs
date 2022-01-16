using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DTO
{
    public partial class QLBanQuanAoContext : DbContext
    {
        public QLBanQuanAoContext()
            : base("name=QLBanQuanAoContext")
        {
        }

        public virtual DbSet<ChiTietSanPham> ChiTietSanPhams { get; set; }
        public virtual DbSet<DongHoaDon> DongHoaDons { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<KichThuoc> KichThuocs { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public virtual DbSet<Luong> Luongs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DongHoaDon>()
                .Property(e => e.MaHoaDon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHoaDon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhuyenMai>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<KichThuoc>()
                .Property(e => e.Ten)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiSanPham>()
                .HasMany(e => e.SanPhams)
                .WithOptional(e => e.LoaiSanPham)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNhanVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SoDienThoai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.Luongs)
                .WithOptional(e => e.NhanVien)
                .HasForeignKey(e => e.MaNhanVien)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.HoaDons)
                .WithOptional(e => e.TaiKhoan)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.NhanViens)
                .WithOptional(e => e.TaiKhoan)
                .HasForeignKey(e => e.IdTK)
                .WillCascadeOnDelete();
        }
    }
}
