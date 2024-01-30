using BUS.IService;
using DAL.DomainClass;
using DAL.NhanVienRepstoryes;
using DAL.KhachHangRepstoryes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class KhachHangService : IKhachHangService
    {
        private KhachHangs _repos;
        public KhachHangService()
        {
            _repos = new KhachHangs();   
        }
       

        public string Add(DonHang dh)
        {
            if (_repos.AddDH(dh) == true)
            {
                return  "thêm thanhd công";
            }
            else
            {
                return "thêm thất bại";
            }
        }

        public List<DonHang> GetDH(string seach)
        {
            if (string.IsNullOrWhiteSpace(seach))
            {
                return _repos.GetallDH();
            }
            else
            {
                int SeachID;
                if (int.TryParse(seach, out SeachID))
                {
                    return _repos.GetallDH().Where(x => x.Id == SeachID).ToList();
                }
                else
                {
                    return new List<DonHang>();
                }
            }
        }

        public List<KhachHang> GetKH(string seach)
        {
            if (string.IsNullOrWhiteSpace(seach))
            {
                return _repos.GetallKH();
            }
            else
            {
                return new List<KhachHang>();
            }
        }

        public List<Sanpham> GetSP(string seach)
        {
            if (string.IsNullOrWhiteSpace(seach))
            {
                return _repos.GetallSP();
            }
            else
            {
                int SeachId;
                if (int.TryParse(seach, out SeachId))
                {
                    return _repos.GetallSP().Where(x => x.Id == SeachId).ToList();
                }
                else
                {
                    return new List<Sanpham>();
                }
            }
        }
        public string Update(KhachHang kh)
        {
            var clone = _repos.GetallKH().FirstOrDefault(x => x.Id == kh.Id);
            clone.TenKhachHang = kh.TenKhachHang;
            clone.DiaChi = kh.DiaChi;
            clone.DienThoai = kh.DienThoai;
            clone.DanhGia = kh.DanhGia;
            if (_repos.UpdateKH(clone) == true)
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }
    }
}
