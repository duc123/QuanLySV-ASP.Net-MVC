using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Quan_ly_sinh_vien_5_tot.Models
{
    public class Quan_ly_sinh_vien_5_totContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Quan_ly_sinh_vien_5_totContext() : base("name=Quan_ly_sinh_vien_5_totContext")
        {
        }

        public System.Data.Entity.DbSet<Quan_ly_sinh_vien_5_tot.Models.SinhVien> SinhViens { get; set; }

        public System.Data.Entity.DbSet<Quan_ly_sinh_vien_5_tot.Models.Lop> Lops { get; set; }

        public void ThemSinhVien(string MaLop,string MSSV, string Ho,string Ten,DateTime NgaySinh) {
            SqlParameter[] param = {
                new SqlParameter("@MaLop",MaLop),
                new SqlParameter("@MSSV",MSSV),
                new SqlParameter("@Ho",Ho),
                new SqlParameter("@Ten",Ten),
                new SqlParameter("@NgaySinh",NgaySinh)
            };

            this.Database.SqlQuery<SinhVien>("ThemSinhVien", param);
        }
    
    }
}
