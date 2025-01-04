namespace Strategy.Structural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context ctx = new Context(new ConcreateStrategy());
            ctx.AddItems("a");
            ctx.AddItems("b");
            ctx.AddItems("c");
            ctx.AddItems("d");
            ctx.AddItems("z");
            ctx.AddItems("y");
            ctx.Sort();

        }
    }
}
