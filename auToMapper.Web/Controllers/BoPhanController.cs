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
    public class BoPhanController : Controller
    {
        private readonly IMapper _mapper;
        public BoPhanController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var bophan = GetBoPhanDetails();
            var bophanViewModel = _mapper.Map<BoPhanViewModel>(bophan);
            return View(bophanViewModel);
        }
        private static BoPhan GetBoPhanDetails()
        {
            return new BoPhan
            {
                BoPhanid = 1,
                TenBoPhan = " Bo phan 6",
                NguoiDungDau = "Nguyen Van C",
                Ngaytao = new DateTime(2022, 6, 3)
            };
        }
    }
}
