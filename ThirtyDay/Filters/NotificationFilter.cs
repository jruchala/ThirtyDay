using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using ThirtyDay.Models;

namespace ThirtyDay.Filters
{
    public class NotificationFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
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
            filterContext.Controller.ViewBag.Notifications = notifications;
        }
    }
}