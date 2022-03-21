using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cao1.entities
{
    [Table("Bo Phan")]
    public class BoPhan
    {
        [Key]
        public int BoPhanid { get; set; }
        [StringLength(50)]
        [Required]
        public string TenBoPhan { get; set; }
        [StringLength(50)]
        [Required]
        public string NguoiDungDau { get; set; }
        [Required]
        public DateTime Ngaytao { get; set; }
    }
}
