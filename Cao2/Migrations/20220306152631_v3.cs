using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cao2.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bo Phan",
                columns: table => new
                {
                    BoPhanid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenBoPhan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NguoiDungDau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ngaytao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bo Phan", x => x.BoPhanid);
                });

            migrationBuilder.CreateTable(
                name: "Dang Ki Mua Ban",
                columns: table => new
                {
                    Orderid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenMatHang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BoPhanid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dang Ki Mua Ban", x => x.Orderid);
                    table.ForeignKey(
                        name: "FK_Dang Ki Mua Ban_Bo Phan_BoPhanid",
                        column: x => x.BoPhanid,
                        principalTable: "Bo Phan",
                        principalColumn: "BoPhanid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "San Pham",
                columns: table => new
                {
                    SanPhamid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSanPham = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LoaiSanPham = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DangKiMuaBanid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_San Pham", x => x.SanPhamid);
                    table.ForeignKey(
                        name: "FK_San Pham_Dang Ki Mua Ban_DangKiMuaBanid",
                        column: x => x.DangKiMuaBanid,
                        principalTable: "Dang Ki Mua Ban",
                        principalColumn: "Orderid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Bo Phan",
                columns: new[] { "BoPhanid", "Ngaytao", "NguoiDungDau", "TenBoPhan" },
                values: new object[] { 1, new DateTime(2022, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van A", " Bo phan 1" });

            migrationBuilder.InsertData(
                table: "Bo Phan",
                columns: new[] { "BoPhanid", "Ngaytao", "NguoiDungDau", "TenBoPhan" },
                values: new object[] { 2, new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Van B", " Bo phan 2" });

            migrationBuilder.InsertData(
                table: "Dang Ki Mua Ban",
                columns: new[] { "Orderid", "BoPhanid", "TenMatHang" },
                values: new object[] { 1, 1, " Mat Hang 1" });

            migrationBuilder.InsertData(
                table: "Dang Ki Mua Ban",
                columns: new[] { "Orderid", "BoPhanid", "TenMatHang" },
                values: new object[] { 2, 2, " Mat Hang 2" });

            migrationBuilder.InsertData(
                table: "San Pham",
                columns: new[] { "SanPhamid", "DangKiMuaBanid", "LoaiSanPham", "SoLuong", "TenSanPham" },
                values: new object[] { 1, 1, "Loai 1", 17, " San Pham 1" });

            migrationBuilder.InsertData(
                table: "San Pham",
                columns: new[] { "SanPhamid", "DangKiMuaBanid", "LoaiSanPham", "SoLuong", "TenSanPham" },
                values: new object[] { 2, 2, "Loai 2", 29, " San Pham 2" });

            migrationBuilder.CreateIndex(
                name: "IX_Dang Ki Mua Ban_BoPhanid",
                table: "Dang Ki Mua Ban",
                column: "BoPhanid");

            migrationBuilder.CreateIndex(
                name: "IX_San Pham_DangKiMuaBanid",
                table: "San Pham",
                column: "DangKiMuaBanid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "San Pham");

            migrationBuilder.DropTable(
                name: "Dang Ki Mua Ban");

            migrationBuilder.DropTable(
                name: "Bo Phan");
        }
    }
}
