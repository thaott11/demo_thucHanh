using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IKhachHangRestoryes
{
    internal interface IKhachHang
    {
        
        public bool UpdateKH(KhachHang kh);
        public List<Sanpham> GetallSP();
        public List<DonHang> GetallDH();
        public List<KhachHang> GetallKH();
        public bool AddDH(DonHang dh);
      
    }
}
