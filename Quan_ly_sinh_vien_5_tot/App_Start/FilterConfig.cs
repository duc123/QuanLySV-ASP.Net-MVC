using System.Web;
using System.Web.Mvc;

namespace Quan_ly_sinh_vien_5_tot
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
