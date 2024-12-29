namespace Proxy.Structural
{
    public class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
