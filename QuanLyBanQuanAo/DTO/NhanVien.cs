namespace DTO
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
            Luongs = new HashSet<Luong>();
        }

        public int ID { get; set; }

        [StringLength(5)]
        public string MaNhanVien { get; set; }

        [StringLength(100)]
        public string HoTen { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(3)]
        public string GioiTinh { get; set; }

        [StringLength(10)]
        public string SoDienThoai { get; set; }

        [StringLength(500)]
        public string DiaChi { get; set; }

        public int? LuongCoBanNgay { get; set; }

        public int? IdTK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Luong> Luongs { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
