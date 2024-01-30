using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    internal interface IKhachHangService
    {
        
        public string Update(KhachHang kh);
        public string Add(DonHang dh);
        public List<Sanpham> GetSP(string seach);
        public List<DonHang> GetDH(string seach);
        public List<KhachHang> GetKH(string seach);
    }
}
