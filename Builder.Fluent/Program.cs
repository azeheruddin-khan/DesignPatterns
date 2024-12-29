namespace Builder.Fluent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBuilder basicBuilder = new BasicBuilder();
            Director director = new Director();
            Laptop laptop = director.Construct(basicBuilder);
            laptop.Show();
        }
    }
}
