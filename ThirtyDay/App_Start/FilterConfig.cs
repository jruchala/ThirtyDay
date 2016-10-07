using System.Web;
using System.Web.Mvc;
using ThirtyDay.Filters;

namespace ThirtyDay
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new NotificationFilter());
        }
    }
}
