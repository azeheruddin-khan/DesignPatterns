namespace AbstractFactory.RealtimeExample.Interface
{
    public interface IPaymentAuthorization
    {
        bool Authorization(decimal amount);
    }
}
