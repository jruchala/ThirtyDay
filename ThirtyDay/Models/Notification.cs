﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThirtyDay.Models
{
    
    public enum NotificationType
        {
            Registration,
            Email
        }

        public class Notification
        {

            public string UserId { get; set; }
            public bool IsDismissed { get; set; }
            public int NotificationId { get; set; }
            public string Title { get; set; }
            public NotificationType NotificationType { get; set; }
            public string Controller { get; set; }
            public string Action { get; set; }
            
        }
    }
