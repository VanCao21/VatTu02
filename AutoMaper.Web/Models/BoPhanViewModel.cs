using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMaper.Web.Models
{
    public class BoPhanViewModel
    {
       
        public int BoPhanid { get; set; }
        
        public string TenBoPhan { get; set; }
        
        public string NguoiDungDau { get; set; }
        
        public DateTime Ngaytao { get; set; }
    }
}