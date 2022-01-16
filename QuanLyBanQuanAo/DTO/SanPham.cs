namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietSanPhams = new HashSet<ChiTietSanPham>();
            DongHoaDons = new HashSet<DongHoaDon>();
        }

        [Key]
        public int MaSanPham { get; set; }

        [StringLength(300)]
        public string TenSanPham { get; set; }

        public int? DonGiaBan { get; set; }

        public int? DonGiaNhap { get; set; }

        public string MoTa { get; set; }

        public int? MaLoaiSanPham { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DongHoaDon> DongHoaDons { get; set; }

        public virtual LoaiSanPham LoaiSanPham { get; set; }
    }
}
