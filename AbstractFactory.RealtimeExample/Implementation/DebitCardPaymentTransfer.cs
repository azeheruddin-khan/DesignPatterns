using AbstractFactory.RealtimeExample.Interface;

namespace AbstractFactory.RealtimeExample.Implementation
{
    public class DebitCardPaymentTransfer : IPaymentTransfer
    {
        public bool Transfer(decimal amount)
        {
            Console.WriteLine(this.GetType().Name);
            //Add logic for UPI Authorization
            return true;
        }
    }
}
