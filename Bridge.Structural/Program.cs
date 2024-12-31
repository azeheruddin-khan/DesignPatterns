namespace Bridge.Structural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Abstraction abstraction = new RefinedAbstraction(new ConcreteImplementorA());
            abstraction.Opertaion();
        }
    }
}
