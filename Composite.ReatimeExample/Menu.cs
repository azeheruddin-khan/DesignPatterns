namespace Composite.ReatimeExample
{
    public class Menu : IMenuItem
    {
        private readonly List<IMenuItem> items = new List<IMenuItem>();
        private string heading;


        public Menu(string heading)
        {
            this.heading = heading;

        }

        public void AddMenuItem(IMenuItem menuItem)
        {
            items.Add(menuItem);
        }

        public void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + heading);
            foreach (IMenuItem item in items)
            {
                item.Display(depth + 2);
            }
        }
    }
}
