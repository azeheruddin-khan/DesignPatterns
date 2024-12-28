using AbstractFactory.RealtimeExample.Interface;

namespace AbstractFactory.RealtimeExample.Implementation
{
    public class DebitCardPaymentFactory : IPaymentFactory
    {
        public IPaymentAuthorization CreateAuthorization()
        {
            return new DebitCardPaymentAuthorization();
            
        }

        public IPaymentTransfer CreateTransfer()
        {
            return new DebitCardPaymentTransfer();
            
        }
    }
}
