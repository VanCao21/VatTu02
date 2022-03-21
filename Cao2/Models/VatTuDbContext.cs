using Cao1.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cao2.Models
{
    public class VatTuDbContext : DbContext
    {
        public VatTuDbContext(DbContextOptions<VatTuDbContext> options) 
            : base(options)
        {

        }
        public DbSet<BoPhan>  boPhans { get; set; }
        public DbSet<DangKiMuaBan>  dangKiMuaBans { get; set; }
        public DbSet<SanPham>   sanPhams { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoPhan>().HasData(new BoPhan
            {
                BoPhanid = 1,
                TenBoPhan = " Bo phan 1",
                NguoiDungDau = "Nguyen Van A",
                Ngaytao = new DateTime(2022,6,3)
            });
            modelBuilder.Entity<BoPhan>().HasData(new BoPhan
            {
                BoPhanid = 2,
                TenBoPhan = " Bo phan 2",
                NguoiDungDau = "Nguyen Van B",
                Ngaytao = new DateTime(2022, 7, 3)
            });
            //modelBuilder.Entity<BoPhan>().HasData(new BoPhan
            //{
            //    BoPhanid = 3,
            //    TenBoPhan = " Bo Phan 3",
            //    NguoiDungDau = "Nguyen Van C",
            //    Ngaytao = new DateTime(2022, 6, 3)
            //});
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DangKiMuaBan>().HasData(new DangKiMuaBan
            {
                Orderid = 1,
                TenMatHang = " Mat Hang 1",
                BoPhanid = 1
            });
            modelBuilder.Entity<DangKiMuaBan>().HasData(new DangKiMuaBan
            {
                Orderid = 2,
                TenMatHang = " Mat Hang 2",
                BoPhanid = 2
            });
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SanPham>().HasData(new SanPham
            {
                SanPhamid = 1,
                TenSanPham = " San Pham 1",
                LoaiSanPham = "Loai 1",
                //Gia = 20000,
                SoLuong = 17,
                DangKiMuaBanid = 1
            });
            modelBuilder.Entity<SanPham>().HasData(new SanPham
            {
                SanPhamid = 2,
                TenSanPham = " San Pham 2",
                LoaiSanPham = "Loai 2",
                //Gia = 30000,
                SoLuong = 29,
                DangKiMuaBanid = 2
            });

        }
    }
}
