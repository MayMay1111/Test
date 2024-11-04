namespace QLCHTT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiaoHang")]
    public partial class GiaoHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiaoHang()
        {
            ChiTietGiaoHangs = new HashSet<ChiTietGiaoHang>();
        }

        [Key]
        [StringLength(13)]
        public string MaGiaoHang { get; set; }

        [StringLength(13)]
        public string MaHoaDon { get; set; }

        [StringLength(13)]
        public string NhanVienGiao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayGiao { get; set; }

        [StringLength(255)]
        public string DiaChi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietGiaoHang> ChiTietGiaoHangs { get; set; }
    }
}
