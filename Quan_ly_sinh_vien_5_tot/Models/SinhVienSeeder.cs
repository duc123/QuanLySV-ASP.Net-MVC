using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quan_ly_sinh_vien_5_tot.Models
{
    public class SinhVienSeeder : System.Data.Entity.DropCreateDatabaseAlways<Quan_ly_sinh_vien_5_totContext>
    {
        protected override void Seed(Quan_ly_sinh_vien_5_totContext context)
        {
            context.SinhViens.Add(new SinhVien
            {
                Lop = new Lop { MaLop = "13DTH10" , LoaiLop = "Đại Học"},
                Ho = "Phan Nguyễn Hồng",
                Ten = "Đức",
                NgaySinh = new DateTime(1994,6,9),
                MSSV = "1311060464"
            });
            
            base.Seed(context);
        }
    }
}