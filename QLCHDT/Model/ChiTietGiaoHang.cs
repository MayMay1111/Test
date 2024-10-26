namespace QLCHDT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("ChiTietGiaoHang")]
    public partial class ChiTietGiaoHang
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(13)]
        public string MaGiaoHang { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(13)]
        public string MaSanPham { get; set; }

        public int? SoLuong { get; set; }

        public virtual GiaoHang GiaoHang { get; set; }
    }
}
