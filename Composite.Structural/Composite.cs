namespace Composite.Structural
{
    public class Composite : IComponent
    {
        protected string name;
        private readonly List<IComponent> components = new List<IComponent>();
        public Composite(string name)
        {
            this.name = name;
        }

        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }

        public void RemoveComponent(IComponent component)
        {
            components.Remove(component);
        }


        public void Display(int depth)
        {
            Console.WriteLine(new string('-', depth)+name);
            foreach (var component in components)
            {
               component.Display(depth+2);
            }
        }
    }
}
