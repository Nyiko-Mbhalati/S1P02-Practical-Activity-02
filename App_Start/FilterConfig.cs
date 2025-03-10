using System.Web;
using System.Web.Mvc;

namespace S1P02___Practical_Activity_02
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
