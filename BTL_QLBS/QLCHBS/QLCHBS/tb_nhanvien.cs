//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLCHBS
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_nhanvien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_nhanvien()
        {
            this.tb_hoadon = new HashSet<tb_hoadon>();
            this.tb_phieunhap = new HashSet<tb_phieunhap>();
        }
    
        public int maNhanVien { get; set; }
        public string tenNhanVien { get; set; }
        public Nullable<System.DateTime> ngaySinh { get; set; }
        public string sdtNhanVien { get; set; }
        public string gioitinh { get; set; }
        public string diaChi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_hoadon> tb_hoadon { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_phieunhap> tb_phieunhap { get; set; }
    }
}
