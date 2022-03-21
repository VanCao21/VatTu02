using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMaper.Web.Models
{
    public class SanPhamViewModel
    {
        public int SanPhamid { get; set; }

        
        public string TenSanPham { get; set; }
        
        public string LoaiSanPham { get; set; }
        
       
        public int SoLuong { get; set; }

        public int? DangKiMuaBanid { get; set; }

        public DangKiMuaBan DangKiMuaBan { get; set; }
    }
}