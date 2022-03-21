using auToMapper.Web.ViewModel;
using AutoMapper;
using Cao1.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace auToMapper.Web
{
    public class AuToMapperProfile : Profile
    {
        public AuToMapperProfile()
        {
            CreateMap<BoPhan, BoPhanViewModel>()
                .ForMember(b => b.NDungDau,
                opt => opt.MapFrom(src => src.NguoiDungDau))
                .ForMember(b => b.TBoPhan,
                opt => opt.MapFrom(src => src.TenBoPhan));
            CreateMap<SanPham, SanPhamViewModel>()
                .ForMember(b => b.TSanPham,
                opt => opt.MapFrom(src => src.TenSanPham))
                .ForMember(b => b.LSanPham,
                opt => opt.MapFrom(src => src.LoaiSanPham))
                .ForMember(b => b.SLuong,
                opt => opt.MapFrom(src => src.SoLuong));
        }
    }
}
