using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quan_ly_sinh_vien_5_tot.Models
{
    public class Lop
    {
        public virtual int LopId { get; set; }
        [StringLength(10)]
        [Column(TypeName="char")]
        public virtual string MaLop { get; set; }
        public virtual string TenLop { get; set; }
        public virtual List<SinhVien> SinhViens { get; set; }
    }
}