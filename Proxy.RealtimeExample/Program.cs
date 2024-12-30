namespace Proxy.RealtimeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IService service = new ProxyService();
            object result = service.GetData("one");
            object result1 = service.GetData("one");
        }
    }
}
