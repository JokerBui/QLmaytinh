namespace WebMayTinh.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Danh_Gia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDanhGia { get; set; }

        public int MaTk { get; set; }

        public int MaSanPham { get; set; }

        [StringLength(250)]
        public string BinhLuan { get; set; }

        public int? XepHang { get; set; }

        public virtual San_Pham San_Pham { get; set; }

        public virtual Tai_Khoan Tai_Khoan { get; set; }
    }
}
