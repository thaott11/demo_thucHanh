using DAL.Context;
using DAL.DomainClass;
using DAL.IKhachHangRestoryes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.KhachHangRepstoryes
{
    public class KhachHangs : IKhachHang
    {
        private DBContext dbContext;
        public KhachHangs()
        {
            dbContext = new DBContext();
        }
        public bool AddDH(DonHang dh)
        {
            dbContext.Add(dh);
            dbContext.SaveChangesAsync();
            return true;
        }

        
        public List<DonHang> GetallDH()
        {
            return dbContext.DonHangs.ToList();
        }

        public List<KhachHang> GetallKH()
        {
            return dbContext.KhachHangs.ToList();
        }

        public List<Sanpham> GetallSP()
        {
            return dbContext.Sanphams.ToList();
        }     
        public bool UpdateKH(KhachHang kh)
        {
            dbContext.Update(kh);
            dbContext.SaveChanges();
            return true;
        }
    }
}
