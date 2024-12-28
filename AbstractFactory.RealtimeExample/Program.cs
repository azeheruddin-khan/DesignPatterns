using AbstractFactory.RealtimeExample.Implementation;
using AbstractFactory.RealtimeExample.Interface;

namespace AbstractFactory.RealtimeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentFactory upiPaymentfactory = new UPIPaymentFactory();
            PaymentProcess paymentProcess = new PaymentProcess (upiPaymentfactory);
            paymentProcess.Transfer(1000M);


            IPaymentFactory debitCardPaymentfactory = new DebitCardPaymentFactory();
            paymentProcess = new PaymentProcess(debitCardPaymentfactory);
            paymentProcess.Transfer(1000M);
        }
    }
}
