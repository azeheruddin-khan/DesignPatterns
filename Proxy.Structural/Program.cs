namespace Proxy.Structural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISubject proxySubject = new ProxySubject();
            proxySubject.Request();
        }
    }
}
