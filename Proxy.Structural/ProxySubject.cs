namespace Proxy.Structural
{
    public class ProxySubject : ISubject
    {
        private readonly ISubject realSubject = new RealSubject();
        public void Request()
        {
           realSubject.Request();
            Console.WriteLine(this.GetType().Name);

        }
    }
}
