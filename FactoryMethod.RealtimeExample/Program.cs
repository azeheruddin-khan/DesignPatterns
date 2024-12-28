using FactoryMethod.RealtimeExample.Implementation;

namespace FactoryMethod.RealtimeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationSystem notificationSystem = new NotificationSystem();
            notificationSystem.SendNotification(new SMSNotifierFactory(), "Good Morning!!");

        }
    }
}
