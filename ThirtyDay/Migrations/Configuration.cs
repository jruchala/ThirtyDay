namespace ThirtyDay.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ThirtyDay.Models.SiteDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ThirtyDay.Models.SiteDataContext context)
        {
            context.Notifications.AddOrUpdate(notification => notification.Title,
                new Notification
                {
                    Title = "John Smith was added to the system.",
                    NotificationType = NotificationType.Registration
                },
                new Notification
                {
                    Title = "Susan Peters was added to the system.",
                    NotificationType = NotificationType.Registration
                },
                new Notification
                {
                    Title = "Just an FYI on Thursday’s meeting",
                    NotificationType = NotificationType.Email
                });
        }
    }
}
