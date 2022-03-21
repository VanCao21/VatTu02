using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMaper.Web.Models
{
    public class DangKiMuaBanViewModel
    {
        public int Orderid { get; set; }
        
        public string TenMatHang { get; set; }
        public int? BoPhanid { get; set; }
        
        public BoPhan BoPhan { get; set; }
    }
}