using BUS.ISeriveNV;
using DAL.DomainClass;
using DAL.NhanVienRepstory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BUS.ServiceNV
{
    public class AdminService : IAdminService
    {
        private Admines _repos;
        public AdminService()
        {
            _repos = new Admines();
        }
        public string Add(NhanVien nv)
        {
            if (_repos.AddNV(nv) == true)
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public List<NhanVien> GetNVs(string search)
        {
            if (string.IsNullOrWhiteSpace(search))
            {
                
                return _repos.GetAllNV();
            }
            else
            {
                int searchNumber;
                if (int.TryParse(search, out searchNumber))
                {
                    return _repos.GetAllNV().Where(x => x.Sdt == searchNumber).ToList();
                }
                else
                {
                    return new List<NhanVien>();
                }
            }
        }
        public string Remove(NhanVien nv)
        {
            var clone = _repos.GetAllNV().FirstOrDefault(x => x.Id == nv.Id);
            //Gọi repos để xóa clone
            if (_repos.RemoveNV(clone) == true)
            {
                return "Xóa thành công";
            }
            else
            {
                return "Xóa thất bại";
            }
        }

        public string Update(NhanVien nv)
        {
            //tạo 1 clone
            var clone = _repos.GetAllNV().FirstOrDefault(x => x.Id == nv.Id);
            clone.Ten = nv.Ten;
            clone.Email = nv.Email;
            clone.Sdt = nv.Sdt;
            clone.Diachi = nv.Diachi;
            if (_repos.UpdateNV(clone) == true)
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }
        public string Add(Sanpham sp)
        {
            if (_repos.AddSP(sp) == true)
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public List<Sanpham> GetSPs(string search)
        {
            if (string.IsNullOrWhiteSpace(search))
            {

                return _repos.GetAllSP();
            }
            else
            {
                int SeachID;
                if (int.TryParse(search, out SeachID))
                {
                    return _repos.GetAllSP().Where(x => x.Id == SeachID).ToList();
                }
                else
                {
                    return new List<Sanpham>();
                }
            }
        }

        public string Remove(Sanpham sp)
        {
            var clone = _repos.GetAllSP().FirstOrDefault(x => x.Id == sp.Id);

            // check xem sản phẩm có trong danh sách không
            if (clone == null)
            {
                return "Không tìm thấy sản phẩm cần xóa.";
            }
            // check xem có xóa được hay không
            if (_repos.RemoveSP(clone))
            {


                return "Xóa thành công";
            }
            else
            {
                return "Xóa thất bại";
            }
        }

        public string Update(Sanpham sp)
        {
            var clone = _repos.GetAllSP().FirstOrDefault(x => x.Id == sp.Id);
            clone.Ten = sp.Ten;
            clone.Mota = sp.Mota;
            clone.Soluongtonkho = sp.Soluongtonkho;
            clone.Giatien = sp.Giatien;
            if (_repos.UpdateSP(clone) == true)
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }

        public List<KhachHang> GetKHs(string search)
        {
            if (string.IsNullOrWhiteSpace(search))
            {

                return _repos.GetAllKH();
            }
            else
            {
                int searchKH;
                if (int.TryParse(search, out searchKH))
                {
                    return _repos.GetAllKH().Where(x => x.Id == searchKH || x.TenKhachHang.Contains(search) || x.DienThoai == searchKH).ToList();
                }
                else
                {
                    return new List<KhachHang>();
                }
            }
        }

        public List<DonHang> GetDHs(string search)
        {
            if (string.IsNullOrWhiteSpace(search))
            {

                return _repos.GetallDH();
            }
            else
            {
                int searchID;
                if (int.TryParse(search, out searchID))
                {
                    return _repos.GetallDH().Where(x => x.Id == searchID).ToList();
                }
                else
                {
                    return new List<DonHang>();
                }
            }
        }

        public List<Admin> GetAdmin(string seach, string matkhau)
        {
            if (string.IsNullOrWhiteSpace(seach))
            {
                return _repos.GetallAdmin();
            }
            else
            {
                int searchID;
                if (int.TryParse(seach, out searchID))
                {
                    return _repos.GetallAdmin().Where(x => x.Id == searchID).ToList();
                }
                else
                {
                    return _repos.GetallAdmin().Where(x => x.TenAdmin == seach && x.MatKhau == matkhau).ToList();
                }
            }
        }
    }
}

