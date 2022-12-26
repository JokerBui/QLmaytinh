namespace WebMayTinh.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_Hoa_Don
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CT_Hoa_Don()
        {
            CT_San_Pham = new HashSet<CT_San_Pham>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaCTHD { get; set; }

        public int MaHoaDon { get; set; }

        public int MaSanPham { get; set; }

        public int? SoLuong { get; set; }

        public int? DonGia { get; set; }

        [StringLength(250)]
        public string GhiChu { get; set; }

        public virtual Hoa_Don Hoa_Don { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_San_Pham> CT_San_Pham { get; set; }
    }
}
