using FactoryMethod.RealtimeExample.Interface;

namespace FactoryMethod.RealtimeExample.Implementation
{
    public class SMSNotifier : INotifier
    {
        public void SendNotification(string message)
        {
           Console.WriteLine(message);
        }
    }
}
