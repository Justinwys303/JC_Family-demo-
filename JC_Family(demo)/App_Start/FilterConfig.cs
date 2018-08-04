using System.Web;
using System.Web.Mvc;

namespace JC_Family_demo_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new Areas.filter.LoginActionFilterAttribute());
        }
    }
}
