using AbstractFactory.RealtimeExample.Interface;

namespace AbstractFactory.RealtimeExample
{
    public class PaymentProcess
    {
        private IPaymentAuthorization _paymentAuthorization;
        private IPaymentTransfer _paymentTransfer;

        public PaymentProcess(IPaymentFactory paymentFactory)
        {
            _paymentAuthorization = paymentFactory.CreateAuthorization();
            _paymentTransfer = paymentFactory.CreateTransfer();

        }

        public bool Transfer(decimal amount)
        {
            if(_paymentAuthorization.Authorization(amount))
            {
                return _paymentTransfer.Transfer(amount);
            }
            return false;

        }


    }
}
