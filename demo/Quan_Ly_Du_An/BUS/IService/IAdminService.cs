using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ISeriveNV
{
    internal interface IAdminService
    {
        public List<Admin> GetAdmin(string seach, string matkhau);
        public string Add(NhanVien nv);
        public string Remove(NhanVien nv);
        public string Update(NhanVien nv);
        public List<NhanVien> GetNVs(string search);

        // Bảng Sản Phẩm
        public string Add(Sanpham sp);
        public string Remove(Sanpham sp);
        public string Update(Sanpham sp);
        public List<Sanpham> GetSPs(string search);

        // tạo bảng khách hàng
        public List<KhachHang> GetKHs(string search);

        // tạo bảng đơn hàng

        public List<DonHang> GetDHs(string search);
    }
}
