using AbstractFactory.RealtimeExample.Interface;

namespace AbstractFactory.RealtimeExample.Implementation
{
    public class UPIPaymentAuthorization : IPaymentAuthorization
    {
        public bool Authorization(decimal amount)
        {
            Console.WriteLine(this.GetType().Name);
            //Add logic for UPI Authorization
            return true;
        }
    }
}
