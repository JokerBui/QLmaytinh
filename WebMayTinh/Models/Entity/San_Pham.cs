namespace WebMayTinh.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;

    public partial class San_Pham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public San_Pham()
        {
            CT_San_Pham = new HashSet<CT_San_Pham>();
            Danh_Gia = new HashSet<Danh_Gia>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaSanPham { get; set; }

        public int MaThuongHieu { get; set; }

        [Required]
        [StringLength(50)]
        public string TenSP { get; set; }

        [StringLength(250)]
        public string MoTa { get; set; }

        [StringLength(250)]
        public string Anh { get; set; }

        public int? SoLuong { get; set; }

        public double GiaBan { get; set; }

        public double GiaNhap { get; set; }

        [StringLength(250)]
        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_San_Pham> CT_San_Pham { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Danh_Gia> Danh_Gia { get; set; }

        public virtual Thuong_Hieu Thuong_Hieu { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }
    }
}
