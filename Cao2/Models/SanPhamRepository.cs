using Cao1.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cao2.Models
{
    public class SanPhamRepository : ISanPhamRepository
    {
        private readonly VatTuDbContext vatTuDbContext;

        public SanPhamRepository(VatTuDbContext vatTuDbContext )
        {
            this.vatTuDbContext = vatTuDbContext;
        }
        public async Task<SanPham> AddSanPham(SanPham sanPham)
        {
            if (sanPham.DangKiMuaBan != null)
            {
                vatTuDbContext.Entry(sanPham.DangKiMuaBan).State = EntityState.Unchanged;
            }
            var result = await vatTuDbContext.sanPhams.AddAsync(sanPham);
            await vatTuDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteSanPham(int SanPhamid)
        {
            var result = await vatTuDbContext.sanPhams.
                FirstOrDefaultAsync(e => e.SanPhamid == SanPhamid);
            if (result != null)
            {
                vatTuDbContext.sanPhams.Remove(result);
                await vatTuDbContext.SaveChangesAsync();
            }
        }

        public async Task<SanPham> GetSanPham(int SanPhamid)
        {
            return await vatTuDbContext.sanPhams
                .Include(e => e.DangKiMuaBan)
                .FirstOrDefaultAsync(e => e.SanPhamid == SanPhamid);
        }

        public async Task<IEnumerable<SanPham>> GetSanPhams()
        {
            return await vatTuDbContext.sanPhams.ToListAsync();
        }

        public async Task<SanPham> GetTenSanPham(string TenSanPham)
        {
            return await vatTuDbContext.sanPhams
               .FirstOrDefaultAsync(e => e.TenSanPham == TenSanPham);
        }

        public async Task<SanPham> UpdateSanPham(SanPham sanPham)
        {
            var result = await vatTuDbContext.sanPhams
               .FirstOrDefaultAsync(e => e.SanPhamid == sanPham.SanPhamid);
            if (result != null)
            {
                result.SanPhamid = sanPham.SanPhamid;
                result.TenSanPham = sanPham.TenSanPham;
                result.LoaiSanPham = sanPham.LoaiSanPham;
                result.SoLuong = sanPham.SoLuong;
                if (sanPham.DangKiMuaBanid != 0)
                {
                    result.DangKiMuaBanid = sanPham.DangKiMuaBanid;
                }
                else if (sanPham.DangKiMuaBan != null)
                {
                    result.DangKiMuaBanid = sanPham.DangKiMuaBan.Orderid;
                }


                await vatTuDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
