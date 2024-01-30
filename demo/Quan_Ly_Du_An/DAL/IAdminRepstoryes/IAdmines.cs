using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.INhanVienRestory
{
    internal interface IAdmines
    {
        // Lấy ra admin
        public List<Admin> GetallAdmin();
        // Lấy ra nhân viên
        public bool AddNV(NhanVien nv);
        public bool RemoveNV(NhanVien nv);
        public bool UpdateNV(NhanVien nv);
        public List<NhanVien> GetAllNV();

        // Bảng Sản Phẩm
        public bool AddSP(Sanpham sp);
        public bool RemoveSP(Sanpham sp);
        public bool UpdateSP(Sanpham sp);
        public List<Sanpham> GetAllSP();

        // bảng khách Hàng
        public List<KhachHang> GetAllKH();

        // bảng đơn hàng
        public List<DonHang> GetallDH();
    }
}
