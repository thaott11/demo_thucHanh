using BUS.IService;
using DAL.DomainClass;
using DAL.NhanVienRepstory;
using DAL.NhanVienRepstoryes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class NhanVienService : INhanVienService
    {
        private NhanViens _repos;
        public NhanVienService()
        {
            _repos = new NhanViens();
            
        }
        public string Add(DonHang dh)
        {          
            if (_repos.AddDH(dh) == true)
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }
       
        public string Add(Sanpham sp)
        {
            if(_repos.AddSP(sp) == true)
            {
                return "thêm Sản phẩm thành công";
            }
            else
            {
                return "thêm thất bại";
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
                return new List<DonHang>();
            }
        }

        public List<DonHang> GetDHs()
        {
            
            return _repos.GetallDH();
        }


        public List<NhanVien> GetNVs(string search)
        {
            if (string.IsNullOrWhiteSpace(search))
            {
                return _repos.GetAllNV();
            }
            else
            {
                    return new List<NhanVien>();
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
                // tìm theo tên và giá
                int searchID;
                if (int.TryParse(search, out searchID))
                {
                    return _repos.GetAllSP().Where(x => x.Id == searchID || x.Ten.Contains(search) || x.Giatien.ToString().Contains(search)).ToList();
                }
                else
                {
                    return new List<Sanpham>();
                }
            }
        }
        public string Update(NhanVien nv)
        {
            var clone = _repos.GetAllNV().FirstOrDefault(x => x.Ten == nv.Ten);
            if (clone != null)
            {
                clone.Ten = nv.Ten;
                clone.Email = nv.Email;
                clone.Sdt = nv.Sdt;
                clone.Diachi = nv.Diachi;
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên");
            }

            if (_repos.UpdateNV(clone))
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
