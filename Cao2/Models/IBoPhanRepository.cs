using Cao1.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cao2.Models
{
    public interface IBoPhanRepository
    {
        Task<IEnumerable<BoPhan>> GetBoPhans();
        Task<BoPhan> GetBoPhan(int BoPhanid);
        Task<BoPhan> GetTenBoPhan(string TenBoPhan);
        Task<BoPhan> GetNguoiDungDau(string NguoiDungDau);
        Task<BoPhan> AddBoPhan(BoPhan boPhan );
        Task<BoPhan> UpdateBoPhan(BoPhan boPhan );
        Task DeleteBoPhan(int BoPhanid);
    }
}
