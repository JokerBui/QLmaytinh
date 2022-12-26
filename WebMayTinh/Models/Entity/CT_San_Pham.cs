namespace WebMayTinh.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_San_Pham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaCTSP { get; set; }

        public int MaCTPN { get; set; }

        public int MaCTHD { get; set; }

        public int MaSanPham { get; set; }

        [StringLength(50)]
        public string ID { get; set; }

        public virtual CT_Hoa_Don CT_Hoa_Don { get; set; }

        public virtual CT_Phieu_Nhap CT_Phieu_Nhap { get; set; }

        public virtual San_Pham San_Pham { get; set; }
    }
}
