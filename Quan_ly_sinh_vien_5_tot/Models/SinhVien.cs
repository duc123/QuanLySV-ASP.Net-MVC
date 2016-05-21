using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quan_ly_sinh_vien_5_tot.Models
{
    public class SinhVien
    {
        public virtual int SinhVienId { get; set; }
        public virtual int LopId { get; set; }
        [StringLength(10)]
        [Column(TypeName="char")]
        public virtual string MSSV { get; set; }
        public virtual string MaLop { get; set; }
        public virtual string Ho { get; set; }
        public virtual string Ten { get; set; }
        public virtual DateTime NgaySinh { get; set; }
        public virtual Lop Lop { get; set; }
    }
}