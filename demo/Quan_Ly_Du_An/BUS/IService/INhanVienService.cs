using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    internal interface INhanVienService
    {
        public string Add(DonHang dh);
        public string Add(Sanpham sp);
        public string Update(NhanVien nv);
        public List<Sanpham> GetSPs(string search);
        public List<NhanVien> GetNVs(string search);
        public List<DonHang> GetDHs(string search);

    }
}
