using AbstractFactory.RealtimeExample.Interface;

namespace AbstractFactory.RealtimeExample.Implementation
{
    public class UPIPaymentTransfer : IPaymentTransfer
    {
        public bool Transfer(decimal amount)
        {
            //Add logic for UPI Authorization
            Console.WriteLine(this.GetType().Name);
            return true;
        }
    }
}
