using FactoryMethod.RealtimeExample.Abstract;
using FactoryMethod.RealtimeExample.Interface;

namespace FactoryMethod.RealtimeExample
{
    public class NotificationSystem
    {
        public void SendNotification(NotifierFactory factory,string message) {

            INotifier notifier = factory.CreateNotifier();
            notifier.SendNotification(message);        
        }
    }
}
