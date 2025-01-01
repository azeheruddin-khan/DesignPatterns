namespace Composite.Structural
{
    public class Leaf : IComponent
    {
        protected string name;
        public Leaf(string name)
        {
            this.name = name;            
        }
        public void Display(int depth)
        {
            Console.WriteLine(new string('-', depth)+name);
        }
    }
}
