using RoverCore.ToastNotification.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverCore.ToastNotification.Abstractions
{
    public class Notification
    {
        public Notification(ToastNotificationType type, string message, int? durationInSeconds)
        {
            Message = message;
            Type = type;
            Duration = durationInSeconds is null or 0 ? null : durationInSeconds * 1000;
        }
        public string Message { get; set; }
        public string BackgroundColor { get; set; }
        public ToastNotificationType Type { get; set; }
        public int? Duration { get; set; }
    }
}
