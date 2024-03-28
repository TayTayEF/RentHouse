namespace ThueTro_DACS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HopDong")]
    public partial class HopDong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCTHD { get; set; }

        public int? idHopDong { get; set; }

        [StringLength(50)]
        public string TenPhongTro { get; set; }

        public decimal? TongTien { get; set; }

        public virtual CT_HopDong CT_HopDong { get; set; }
    }
}
