using AbstractFactory.RealtimeExample.Interface;

namespace AbstractFactory.RealtimeExample.Implementation
{
    public class UPIPaymentFactory : IPaymentFactory
    {
        public IPaymentAuthorization CreateAuthorization()
        {
            return new UPIPaymentAuthorization();
            
        }

        public IPaymentTransfer CreateTransfer()
        {
            return new UPIPaymentTransfer();
            
        }
    }
}
