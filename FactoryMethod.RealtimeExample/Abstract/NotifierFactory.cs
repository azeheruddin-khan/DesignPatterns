using FactoryMethod.RealtimeExample.Interface;

namespace FactoryMethod.RealtimeExample.Abstract
{
    public abstract class NotifierFactory
    {
        public abstract INotifier CreateNotifier();
    }
}
