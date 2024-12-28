using FactoryMethod.RealtimeExample.Abstract;
using FactoryMethod.RealtimeExample.Interface;

namespace FactoryMethod.RealtimeExample.Implementation
{
    public class EmailNotifierFactory : NotifierFactory
    {
        public override INotifier CreateNotifier()
        {
            return new EmailNotifier();
            
        }
    }
}
