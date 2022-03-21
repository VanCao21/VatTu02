using Cao1.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cao2.Models
{
    public class BoPhanRepository : IBoPhanRepository
    {
        private readonly VatTuDbContext vatTuDbContext;

        public BoPhanRepository(VatTuDbContext vatTuDbContext)
        {
            this.vatTuDbContext = vatTuDbContext;
        }
        public async Task<BoPhan> AddBoPhan(BoPhan boPhan)
        {
            //if (boPhan.catergory != null)
            //{
            //    productDbContext.Entry(product.catergory).State = EntityState.Unchanged;
            //}
            var result = await vatTuDbContext.boPhans.AddAsync(boPhan);
            await vatTuDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteBoPhan(int BoPhanid)
        {
            var result = await vatTuDbContext.boPhans.
                FirstOrDefaultAsync(e => e.BoPhanid == BoPhanid );
            if (result != null)
            {
                vatTuDbContext.boPhans.Remove(result);
                await vatTuDbContext.SaveChangesAsync();
            }
        }

        public async Task<BoPhan> GetBoPhan(int BoPhanid)
        {
            return await vatTuDbContext.boPhans
               //.Include(e => e.BoPhanid)
               .FirstOrDefaultAsync(e => e.BoPhanid == BoPhanid);
        }

        public async Task<IEnumerable<BoPhan>> GetBoPhans()
        {
            return await vatTuDbContext.boPhans.ToListAsync();
        }

        public async Task<BoPhan> GetNguoiDungDau(string NguoiDungDau)
        {
            return await vatTuDbContext.boPhans
                .FirstOrDefaultAsync(e => e.NguoiDungDau == NguoiDungDau);
        }

        public async Task<BoPhan> GetTenBoPhan(string TenBoPhan)
        {
            return await vatTuDbContext.boPhans
                 .FirstOrDefaultAsync(e => e.TenBoPhan == TenBoPhan);
        }

        public async Task<BoPhan> UpdateBoPhan(BoPhan boPhan)
        {
            var result = await vatTuDbContext.boPhans
                .FirstOrDefaultAsync(e => e.BoPhanid == boPhan.BoPhanid);
            if (result != null)
            {
                result.BoPhanid = boPhan.BoPhanid;
                result.TenBoPhan = boPhan.TenBoPhan;
                result.NguoiDungDau = boPhan.NguoiDungDau;
                result.Ngaytao = boPhan.Ngaytao;

                await vatTuDbContext.SaveChangesAsync();
                return result; 
                
            }
            return null;
        }
    }
}
