namespace WebMayTinh.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Phieu_Nhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phieu_Nhap()
        {
            CT_Phieu_Nhap = new HashSet<CT_Phieu_Nhap>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPNK { get; set; }

        public int MaTk { get; set; }

        [Required]
        [StringLength(50)]
        public string LoaiPhieu { get; set; }

        [Required]
        [StringLength(50)]
        public string TrangThai { get; set; }

        [StringLength(250)]
        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_Phieu_Nhap> CT_Phieu_Nhap { get; set; }

        public virtual Tai_Khoan Tai_Khoan { get; set; }
    }
}
