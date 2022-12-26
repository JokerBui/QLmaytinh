namespace WebMayTinh.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_Phieu_Nhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CT_Phieu_Nhap()
        {
            CT_San_Pham = new HashSet<CT_San_Pham>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaCTPN { get; set; }

        public int MaPNK { get; set; }

        public int MaSanPham { get; set; }

        public int SoLuong { get; set; }

        public int? TongTien { get; set; }

        [StringLength(250)]
        public string GhiChu { get; set; }

        public virtual Phieu_Nhap Phieu_Nhap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_San_Pham> CT_San_Pham { get; set; }
    }
}
