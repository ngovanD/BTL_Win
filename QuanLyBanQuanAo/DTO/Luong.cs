namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Luong")]
    public partial class Luong
    {
        [Key]
        public int ID_Luong { get; set; }

        public int? MaNhanVien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThangNam { get; set; }

        public int? SoNgayCong { get; set; }

        public int? Thuong { get; set; }

        public int? LuongCoBanNgay { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
