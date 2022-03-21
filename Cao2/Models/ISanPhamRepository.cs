using Cao1.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cao2.Models
{
    public interface ISanPhamRepository
    {
        Task<IEnumerable<SanPham>>  GetSanPhams();
        Task<SanPham> GetSanPham(int SanPhamid);
        Task<SanPham> GetTenSanPham(string TenSanPham);
        
        Task<SanPham> AddSanPham(SanPham  sanPham);
        Task<SanPham> UpdateSanPham(SanPham sanPham);
        Task DeleteSanPham(int SanPhamid);
    }
}
