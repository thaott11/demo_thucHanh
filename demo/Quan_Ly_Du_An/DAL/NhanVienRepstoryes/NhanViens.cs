using DAL.DomainClass;
using DAL.INhanVienRepstoryes;
using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL.NhanVienRepstoryes
{
    public class NhanViens : INhanViens
    {
        private DBContext _dbContext;
        public NhanViens()
        {
            _dbContext = new DBContext();
        }
        public bool AddDH(DonHang dh)
        {
            _dbContext.Add(dh);
            _dbContext.SaveChangesAsync();
            return true;
        }

        public bool AddSP(Sanpham sp)
        {
            _dbContext.Add(sp);
            _dbContext.SaveChanges();
            return true;
        }

        public List<DonHang> GetallDH()
        {
            return _dbContext.DonHangs.ToList();
        }

        public List<NhanVien> GetAllNV()
        {
            return _dbContext.NhanViens.ToList();
        }

        public List<Sanpham> GetAllSP()
        {
            return _dbContext.Sanphams.ToList();
        }

        public bool UpdateNV(NhanVien nv)
        {
            _dbContext.Update(nv);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
