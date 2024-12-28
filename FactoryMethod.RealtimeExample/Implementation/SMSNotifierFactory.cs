using FactoryMethod.RealtimeExample.Abstract;
using FactoryMethod.RealtimeExample.Interface;

namespace FactoryMethod.RealtimeExample.Implementation
{
    public class SMSNotifierFactory : NotifierFactory
    {
        public override INotifier CreateNotifier()
        {
            return new SMSNotifier();
        }
    }
}
