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
    
    public partial class tb_sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_sach()
        {
            this.tb_cthoadon = new HashSet<tb_cthoadon>();
            this.tb_ctphieunhap = new HashSet<tb_ctphieunhap>();
        }
    
        public int maSach { get; set; }
        public string tenSach { get; set; }
        public Nullable<int> maLoaiSach { get; set; }
        public Nullable<int> maTacGia { get; set; }
        public Nullable<System.DateTime> namXuatBan { get; set; }
        public Nullable<int> giaBia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_cthoadon> tb_cthoadon { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ctphieunhap> tb_ctphieunhap { get; set; }
        public virtual tb_loaisach tb_loaisach { get; set; }
        public virtual tb_tacgia tb_tacgia { get; set; }
    }
}