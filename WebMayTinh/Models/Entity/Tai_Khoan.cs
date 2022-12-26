namespace WebMayTinh.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tai_Khoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tai_Khoan()
        {
            Danh_Gia = new HashSet<Danh_Gia>();
            Hoa_Don = new HashSet<Hoa_Don>();
            Phieu_Nhap = new HashSet<Phieu_Nhap>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaTk { get; set; }

        [Required]
        [StringLength(50)]
        public string HoVaTen { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(50)]
        public string MatKhau { get; set; }

        public int MaLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Danh_Gia> Danh_Gia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hoa_Don> Hoa_Don { get; set; }

        public virtual Loai_TK Loai_TK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieu_Nhap> Phieu_Nhap { get; set; }
    }
}
