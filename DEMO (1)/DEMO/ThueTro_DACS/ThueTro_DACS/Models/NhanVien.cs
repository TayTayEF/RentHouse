namespace ThueTro_DACS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            CT_HopDong = new HashSet<CT_HopDong>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdNhanVien { get; set; }

        [StringLength(50)]
        public string TenNhanVien { get; set; }

        public int? SDT { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(500)]
        public string UrlHinhAnh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HopDong> CT_HopDong { get; set; }
    }
}
