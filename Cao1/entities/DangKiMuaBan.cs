using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cao1.entities
{
    [Table("Dang Ki Mua Ban")]
    public class DangKiMuaBan
    {
        [Key]
        public int Orderid { get; set; }
        [StringLength(50)]
        [Required]
        public string TenMatHang { get; set; }
        public int? BoPhanid { get; set; }
        [ForeignKey("BoPhanid")]
        public BoPhan BoPhan { get; set; }
    }
}
