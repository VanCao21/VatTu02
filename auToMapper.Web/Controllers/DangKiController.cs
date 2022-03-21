using auToMapper.Web.ViewModel;
using AutoMapper;
using Cao1.entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace auToMapper.Web.Controllers
{
    public class DangKiController : Controller
    {
        private readonly IMapper _mapper;
        public DangKiController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var dangki = GetDangKiDetails();
            var dangkiViewModel = _mapper.Map<DangKiMuaBanViewModel>(dangki);
            return View(dangkiViewModel);
        }
        private static DangKiMuaBan GetDangKiDetails()
        {
            return new DangKiMuaBan
            {
                Orderid = 6,
                TenMatHang = " Mat Hang 6",
                BoPhanid = 1,
                BoPhan = new BoPhan { NguoiDungDau = "Cao"}
            };
        }
    }
}
