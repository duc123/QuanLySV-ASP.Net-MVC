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
        [StringLength(10,ErrorMessage="Mã lớp quá dài")]
        [Column(TypeName="char")]
        [Index(IsUnique=true)]
        [Required(ErrorMessage="Cần nhập mã lớp")]
        [Display(Name="Mã Lớp")]
        public virtual string MaLop { get; set; }
        [Required(ErrorMessage="Cần chọn loại lớp")]
        [StringLength(20)]
        [Column(TypeName="nchar")]
        [Display(Name="Loại Lớp")]
        public virtual string LoaiLop { get; set; }
        public virtual List<SinhVien> SinhViens { get; set; }
    }
}