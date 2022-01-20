using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverCore.ToastNotification.Abstractions
{
    public interface ITempDataService
    {
        T Get<T>(string key) where T : class;
        T Peek<T>(string key) where T : class;
        void Add(string key, object value);
        /// <returns></returns>
        bool Remove(string key);
    }
}
