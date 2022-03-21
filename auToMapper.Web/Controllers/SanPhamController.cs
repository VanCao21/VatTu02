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
    public class SanPhamController : Controller
    {
        private readonly IMapper _mapper;
        public SanPhamController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var sanpham = GetSanPhamDetails();
            var sanphamViewModel = _mapper.Map<SanPhamViewModel>(sanpham);
            return View(sanphamViewModel);
        }
        private static SanPham GetSanPhamDetails()
        {
            return new SanPham
            {
                SanPhamid = 1,
                TenSanPham = " Bo phan 6",
                LoaiSanPham = "Nguyen Van C",
                SoLuong = 2,
                DangKiMuaBanid = 1,
                DangKiMuaBan = new DangKiMuaBan { TenMatHang = "Đồ chơi" }
            };
        }
    }
}
