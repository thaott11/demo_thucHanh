using DAL.Context;
using DAL.DomainClass;
using DAL.IRepstoryes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repstoryes
{
    public class SinhVienRepstoryes : ISinhVienRepstoryes
    {
        private DBContext _dbContext;
        public SinhVienRepstoryes()
        {
            _dbContext = new DBContext();
        }

        public bool AddSV(Sinhvien sv)
        {
            _dbContext.Add(sv);
            _dbContext.SaveChangesAsync();
            return true;
        }

        public List<Sinhvien> GetAllSV()
        {
            return _dbContext.Sinhviens.ToList();
        }


        public bool RemoveSV(Sinhvien sv)
        {
            _dbContext.Remove(sv);
            _dbContext.SaveChanges();
            return true;
        }

        public bool UpdateSV(Sinhvien sv)
        {
            _dbContext.Update(sv);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
