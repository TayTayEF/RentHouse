namespace ThueTro_DACS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_HopDong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CT_HopDong()
        {
            HopDongs = new HashSet<HopDong>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdHopDong { get; set; }

        public int? IdKhachHang { get; set; }

        public int? IdChuTro { get; set; }

        public int? IdNhanvien { get; set; }

        public int? IdPhongTro { get; set; }

        public DateTime? NgayBatDau { get; set; }

        public DateTime? NgayKetThuc { get; set; }

        public decimal? TienCoc { get; set; }

        public decimal? TienThue { get; set; }

        public decimal? TongTien { get; set; }

        public virtual ChuTro ChuTro { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual PhongTro PhongTro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HopDong> HopDongs { get; set; }
    }
}
