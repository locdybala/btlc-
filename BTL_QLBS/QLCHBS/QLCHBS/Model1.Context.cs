﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class qlbsEntities : DbContext
    {
        public qlbsEntities()
            : base("name=qlbsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tb_cthoadon> tb_cthoadon { get; set; }
        public virtual DbSet<tb_ctphieunhap> tb_ctphieunhap { get; set; }
        public virtual DbSet<tb_hoadon> tb_hoadon { get; set; }
        public virtual DbSet<tb_khachhang> tb_khachhang { get; set; }
        public virtual DbSet<tb_loaisach> tb_loaisach { get; set; }
        public virtual DbSet<tb_nhacungcap> tb_nhacungcap { get; set; }
        public virtual DbSet<tb_nhanvien> tb_nhanvien { get; set; }
        public virtual DbSet<tb_phieunhap> tb_phieunhap { get; set; }
        public virtual DbSet<tb_sach> tb_sach { get; set; }
        public virtual DbSet<tb_tacgia> tb_tacgia { get; set; }
    }
}