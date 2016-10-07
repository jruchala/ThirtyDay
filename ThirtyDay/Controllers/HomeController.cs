using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThirtyDay.Models;

namespace ThirtyDay.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var context = new SiteDataContext();
            var notifications = context.Notifications
                .GroupBy(n => n.NotificationType)
                .Select(g => new NotificationViewModel
                {
                    Count = g.Count(),
                    NotificationType = g.Key.ToString(),
                    BadgeClass = NotificationType.Email == g.Key
                    ? "success"
                    : "info"
                });

            ViewBag.Notifications = notifications;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}