using Cao1.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cao2.Models
{
    public interface IDangKiMuaBanRepository
    {
        Task<IEnumerable<DangKiMuaBan>>  GetDangKiMuaBans();
        Task<DangKiMuaBan> GetDangKi(int Orderid);
        Task<DangKiMuaBan> GetTenMatHang(string TenMatHang);
        Task<DangKiMuaBan> AddDangKi(DangKiMuaBan  dangKiMuaBan);
        Task<DangKiMuaBan> UpdateDangKi(DangKiMuaBan dangKiMuaBan);
        Task DeleteDangKi(int Orderid);


    }
}
