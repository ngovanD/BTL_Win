namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            DongHoaDons = new HashSet<DongHoaDon>();
        }

        [Key]
        [StringLength(14)]
        public string MaHoaDon { get; set; }

        public DateTime? ThoiGian { get; set; }

        public bool? LoaiHoaDon { get; set; }

        public int? GiamGia { get; set; }

        public int? TongTien { get; set; }

        public int? ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DongHoaDon> DongHoaDons { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
