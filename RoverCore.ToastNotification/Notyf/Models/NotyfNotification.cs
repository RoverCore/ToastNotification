using RoverCore.ToastNotification.Abstractions;
using RoverCore.ToastNotification.Enums;

namespace RoverCore.ToastNotification.Notyf.Models
{
    public class NotyfNotification : Notification
    {
        public NotyfNotification(ToastNotificationType type, string message, int? durationInSeconds) : base(type, message, durationInSeconds)
        {
           
        }
        public string Icon { get; set; }
    }
}
