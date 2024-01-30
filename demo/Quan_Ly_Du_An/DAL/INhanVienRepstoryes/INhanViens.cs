using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.INhanVienRepstoryes
{
    internal interface INhanViens
    {
        public bool AddDH(DonHang dh);
        public bool AddSP(Sanpham sp);
        public bool UpdateNV(NhanVien nv);
        public List<Sanpham> GetAllSP();
        public List<NhanVien> GetAllNV();
       
        public List<DonHang> GetallDH();
    }
}
