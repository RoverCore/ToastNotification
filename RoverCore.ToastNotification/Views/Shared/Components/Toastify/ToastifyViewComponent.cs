using RoverCore.ToastNotification.Abstractions;
using RoverCore.ToastNotification.Helpers;
using RoverCore.ToastNotification.Toastify;
using RoverCore.ToastNotification.Toastify.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverCore.ToastNotification.Views.Shared.Components.Toastify
{
    [ViewComponent(Name = "Toastify")]
    public class ToastifyViewComponent : ViewComponent
    {
        private readonly IToastifyService _service;

        public ToastifyViewComponent(IToastifyService service, ToastifyEntity options)
        {
            this._service = service;
            _options = options;
        }

        public ToastifyEntity _options { get; }

        public IViewComponentResult Invoke()
        {
            var model = new ToastifyViewModel
            {
                Configuration = _options,
                Notifications = _service.ReadAllNotifications()
            };
            return View("Default", model);
        }
    }
}
