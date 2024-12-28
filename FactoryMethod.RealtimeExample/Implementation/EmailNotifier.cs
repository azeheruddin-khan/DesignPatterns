using FactoryMethod.RealtimeExample.Interface;

namespace FactoryMethod.RealtimeExample.Implementation
{
    public class EmailNotifier : INotifier
    {
        public void SendNotification(string message)
        {
            Console.WriteLine(message);
        }
    }
}
