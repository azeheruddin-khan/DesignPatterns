namespace AbstractFactory.RealtimeExample.Interface
{
    public interface IPaymentFactory
    {
        IPaymentAuthorization CreateAuthorization();
        IPaymentTransfer CreateTransfer();
    }
}
