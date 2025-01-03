using System.Runtime.CompilerServices;
using static Iterator.Structural.ConcreteAggregate;

namespace Iterator.Structural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate aggregate = new ConcreteAggregate();
            aggregate[0] = "a";
            aggregate[1] = "b";
            aggregate[2] = "c";
            aggregate[3] = "d";

            var iterator = aggregate.CreateIterator();

            Console.WriteLine("--Strating iterator---");
            Console.WriteLine(iterator.First());
            Console.WriteLine(iterator.Next());
            Console.WriteLine(iterator.Previous());
            Console.WriteLine(iterator.Current());

        }
    }
}
