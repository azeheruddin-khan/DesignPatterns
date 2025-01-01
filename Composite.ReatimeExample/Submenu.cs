namespace Composite.ReatimeExample
{
    public class Submenu : IMenuItem
    {
        private string heading;
        private string linkUrl;

        public Submenu(string heading, string linkUrl)
        {
            this.heading = heading;
            this.linkUrl = linkUrl;

        }
        public void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + heading + ' ' + linkUrl);
        }
    }
}
