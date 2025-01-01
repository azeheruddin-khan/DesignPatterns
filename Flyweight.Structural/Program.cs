namespace Flyweight.Structural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FlyweightFactory factory = new FlyweightFactory();

            Flyweight flyweight = factory.GetFlyweight("x");
            flyweight.Operation(100);
        }
    }
}
