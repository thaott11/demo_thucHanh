using DAL.Context;
using DAL.DomainClass;
using DAL.INhanVienRestory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.NhanVienRepstory
{
    public class Admines : IAdmines
    {
        private DBContext _dbContext;
        public Admines()
        {
            _dbContext = new DBContext();
        }
        public bool AddNV(NhanVien nv)
        {
            _dbContext.Add(nv);
            _dbContext.SaveChangesAsync();
            return true;
        }

        public List<NhanVien> GetAllNV()
        {
            return _dbContext.NhanViens.ToList();
        }

        public bool RemoveNV(NhanVien nv)
        {
            _dbContext.Remove(nv);
            _dbContext.SaveChanges();
            return true;
        }

        public bool UpdateNV(NhanVien nv)
        {
            _dbContext.Update(nv);
            _dbContext.SaveChanges();
            return true;
        }
        public bool AddSP(Sanpham sp)
        {
            _dbContext.Add(sp);
            _dbContext.SaveChangesAsync();
            return true;
        }

        public List<Sanpham> GetAllSP()
        {
            return _dbContext.Sanphams.ToList();
        }

        public bool RemoveSP(Sanpham sp)
        {
            _dbContext.Remove(sp);
            _dbContext.SaveChanges();
            return true;
        }

        public bool UpdateSP(Sanpham sp)
        {
            _dbContext.Update(sp);
            _dbContext.SaveChanges();
            return true;
        }
        public List<KhachHang> GetAllKH()
        {
            return _dbContext.KhachHangs.ToList();
        }
        
        public List<DonHang> GetallDH()
        {
            return _dbContext.DonHangs.ToList();
        }

        public List<Admin> GetallAdmin()
        {
            return _dbContext.Admins.ToList();
        }
    }
}


