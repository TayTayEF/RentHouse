namespace ThueTro_DACS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhongTro")]
    public partial class PhongTro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhongTro()
        {
            CT_HinhAnh = new HashSet<CT_HinhAnh>();
            CT_HopDong = new HashSet<CT_HopDong>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdPhongTro { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public decimal? GiaCoc { get; set; }

        public decimal? GiaThue { get; set; }

        [StringLength(250)]
        public string DiaChi { get; set; }

        [StringLength(500)]
        public string UrlHinhAnh { get; set; }

        public int? IdChuTro { get; set; }

        [StringLength(500)]
        public string MoTa { get; set; }

        public int? SDT { get; set; }

        public double? DienTich { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HinhAnh> CT_HinhAnh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HopDong> CT_HopDong { get; set; }
    }
}
