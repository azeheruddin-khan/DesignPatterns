namespace Singleton.ThreadSafe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton singletonFirst = Singleton.Instance();
            Singleton singletonSecond = Singleton.Instance();

            if(object.ReferenceEquals(singletonFirst, singletonSecond))
            {
                Console.WriteLine("Objects are same");
            }
        }
    }
}
