namespace Builder.Structural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new ConcreteBuilder1();
            Director director = new Director();
            director.Construct(builder);
            Product product = builder.GetProduct();

            product.Show();

        }
    }
}
