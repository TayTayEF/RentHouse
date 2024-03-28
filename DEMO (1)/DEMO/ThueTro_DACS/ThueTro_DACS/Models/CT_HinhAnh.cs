namespace ThueTro_DACS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_HinhAnh
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCTHA { get; set; }

        public int? IdPhongTro { get; set; }

        [StringLength(500)]
        public string UrlHinhAnh { get; set; }

        public virtual PhongTro PhongTro { get; set; }
    }
}
