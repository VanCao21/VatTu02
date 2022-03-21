using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cao1.entities
{
    [Table("San Pham")]
    public class SanPham
    {
        [Key]
        public int SanPhamid { get; set; }

        [Required]
        [StringLength(50)]
        public string TenSanPham { get; set; }
        [Required]
        [StringLength(50)]
        public string LoaiSanPham { get; set; }
        //[Required]
        //public decimal Gia { get; set; }
        [Required]
        public int SoLuong { get; set; }
        public int? DangKiMuaBanid { get; set; }
        [ForeignKey("DangKiMuaBanid")]

        public DangKiMuaBan DangKiMuaBan { get; set; }
    }
}
