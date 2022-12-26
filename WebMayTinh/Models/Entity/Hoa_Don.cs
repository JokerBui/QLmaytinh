namespace WebMayTinh.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hoa_Don
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hoa_Don()
        {
            CT_Hoa_Don = new HashSet<CT_Hoa_Don>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHoaDon { get; set; }

        public int MaSanPham { get; set; }

        public int MaTk { get; set; }

        [Column(TypeName = "date")]
        public DateTime ThoiGianMua { get; set; }

        public int TrangThai { get; set; }

        [StringLength(250)]
        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_Hoa_Don> CT_Hoa_Don { get; set; }

        public virtual Tai_Khoan Tai_Khoan { get; set; }
    }
}
