using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quan_ly_sinh_vien_5_tot.Models
{
    public class SinhVien
    {
        [Display(Name="#")]
        public virtual int SinhVienId { get; set; }
        public virtual int LopId { get; set; }
        [StringLength(10,ErrorMessage="Mã số sinh viên quá dài")]
        [Column(TypeName="char")]
        [Display(Name="MSSV")]
        [Index(IsUnique=true)]
        [Required(ErrorMessage="Cần nhập mã số sinh viên")]
        [Remote("mssvDaTonTai","SinhVien",HttpMethod="POST",ErrorMessage="Mã số sinh viên đã tồn tại")]
        public virtual string MSSV { get; set; }
        [Display(Name="Họ")]
        [Column(TypeName="nchar")]
        [StringLength(25,ErrorMessage="Họ quá dài")]
        [Required(ErrorMessage="Cần nhập họ")]
        public virtual string Ho { get; set; }
        [Display(Name="Tên")]
        [Required(ErrorMessage="Cần nhập tên")]
        [Column(TypeName="nchar")]
        [StringLength(25,ErrorMessage="Tên quá dài")]
        public virtual string Ten { get; set; }
        [DataType(DataType.Date)]
        [Display(Name="Ngày sinh")]
        [Required(ErrorMessage="Cần nhập ngày sinh")]
        public virtual DateTime NgaySinh { get; set; }
        public virtual Lop Lop { get; set; }
    }
}