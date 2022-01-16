namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhuyenMai")]
    public partial class KhuyenMai
    {
        [Key]
        public int MaKhuyenMai { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        public int? GiaTri { get; set; }

        public int? SoLuongCon { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HanSuDung { get; set; }
    }
}
