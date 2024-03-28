namespace ThueTro_DACS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhanHoi")]
    public partial class PhanHoi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdPhanHoi { get; set; }

        public int? IdKhachHang { get; set; }

        [StringLength(500)]
        public string NoiDungPhanHoi { get; set; }

        public DateTime? NgayDang { get; set; }

        public int? IdPhongTro { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
