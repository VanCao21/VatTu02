using Cao1.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cao2.Models
{
    public class DangKiMuaBanRepository : IDangKiMuaBanRepository
    {
        private readonly VatTuDbContext vatTuDbContext;

        public DangKiMuaBanRepository(VatTuDbContext vatTuDbContext)
        {
            this.vatTuDbContext = vatTuDbContext;
        }
        public async Task<DangKiMuaBan> AddDangKi(DangKiMuaBan dangKiMuaBan)
        {
            if (dangKiMuaBan.BoPhan != null)
            {
                vatTuDbContext.Entry(dangKiMuaBan.BoPhan).State = EntityState.Unchanged;
            }
            var result = await vatTuDbContext.dangKiMuaBans.AddAsync(dangKiMuaBan);
            await vatTuDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteDangKi(int Orderid)
        {
            var result = await vatTuDbContext.dangKiMuaBans.
                FirstOrDefaultAsync(e => e.Orderid == Orderid);
            if (result != null)
            {
                vatTuDbContext.dangKiMuaBans.Remove(result);
                await vatTuDbContext.SaveChangesAsync();
            }
        }

        public async Task<DangKiMuaBan> GetDangKi(int Orderid)
        {
            return await vatTuDbContext.dangKiMuaBans
               .Include(e => e.BoPhan)
               .FirstOrDefaultAsync(e => e.Orderid == Orderid);
        }

        public async Task<IEnumerable<DangKiMuaBan>> GetDangKiMuaBans()
        {
            return await vatTuDbContext.dangKiMuaBans.ToListAsync();
        }

        public async Task<DangKiMuaBan> GetTenMatHang(string TenMatHang)
        {
            return await vatTuDbContext.dangKiMuaBans
                 .FirstOrDefaultAsync(e => e.TenMatHang == TenMatHang);
        }

        public async Task<DangKiMuaBan> UpdateDangKi(DangKiMuaBan dangKiMuaBan)
        {
            var result = await vatTuDbContext.dangKiMuaBans
                .FirstOrDefaultAsync(e => e.Orderid == dangKiMuaBan.Orderid);
            if (result != null)
            {
                result.Orderid = dangKiMuaBan.Orderid;
                result.TenMatHang = dangKiMuaBan.TenMatHang;
               
                if (dangKiMuaBan.BoPhanid != 0)
                {
                    result.BoPhanid = dangKiMuaBan.BoPhanid;
                }
                else if (dangKiMuaBan.BoPhanid != null)
                {
                    result.BoPhanid = dangKiMuaBan.BoPhan.BoPhanid;
                }


                await vatTuDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
