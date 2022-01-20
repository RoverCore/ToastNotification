using RoverCore.ToastNotification.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace RoverCore.ToastNotification.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseNotyf(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<NotyfMiddleware>();
            return builder;
        }
    }
}
