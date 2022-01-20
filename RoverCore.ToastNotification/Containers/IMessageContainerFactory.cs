using RoverCore.ToastNotification.Abstractions;

namespace RoverCore.ToastNotification.Containers
{
    public interface IMessageContainerFactory
    {
        IToastNotificationContainer<TMessage> Create<TMessage>() where TMessage : class;
    }
}
