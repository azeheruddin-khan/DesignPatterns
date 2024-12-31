namespace Adapter.Structural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITarget target = new Adapter();
            target.Process();
        }
    }
}
