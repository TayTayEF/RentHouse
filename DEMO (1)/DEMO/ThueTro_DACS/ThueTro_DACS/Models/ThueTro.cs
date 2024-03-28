using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ThueTro_DACS.Models
{
    public partial class ThueTro : DbContext
    {
        public ThueTro()
            : base("name=ThueTro")
        {
        }

        public virtual DbSet<ChuTro> ChuTroes { get; set; }
        public virtual DbSet<CT_HinhAnh> CT_HinhAnh { get; set; }
        public virtual DbSet<CT_HopDong> CT_HopDong { get; set; }
        public virtual DbSet<HopDong> HopDongs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhanHoi> PhanHois { get; set; }
        public virtual DbSet<PhongTro> PhongTroes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CT_HopDong>()
                .Property(e => e.TienCoc)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CT_HopDong>()
                .Property(e => e.TienThue)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CT_HopDong>()
                .Property(e => e.TongTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HopDong>()
                .Property(e => e.TongTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PhongTro>()
                .Property(e => e.GiaCoc)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PhongTro>()
                .Property(e => e.GiaThue)
                .HasPrecision(18, 0);
        }
    }
}
