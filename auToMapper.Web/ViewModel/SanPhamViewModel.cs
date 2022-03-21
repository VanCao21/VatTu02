using Cao1.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace auToMapper.Web.ViewModel
{
    public class SanPhamViewModel
    {
        public int SanPhamid { get; set; }

        public string TSanPham { get; set; }
        public string LSanPham { get; set; }
        public int SLuong { get; set; }
        public int? DangKiMuaBanid { get; set; }
        public DangKiMuaBan DangKiMuaBan { get; set; }
    }
}
