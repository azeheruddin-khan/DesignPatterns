using System.ComponentModel.Design;

namespace Composite.ReatimeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Menu homeMenu = new Menu("Home");
            Menu technologies = new Menu("Technologies");
            IMenuItem aboutUs = new Submenu("About US", "/About US");

            technologies.AddMenuItem(new Submenu("C#", "/Technologies/c#"));
            technologies.AddMenuItem(new Submenu("Java", "/Technologies/java"));
            technologies.AddMenuItem(new Submenu("HTML", "/Technologies/html"));
            technologies.AddMenuItem(new Submenu("CSS", "/Technologies/css"));

            homeMenu.AddMenuItem(technologies);
            homeMenu.AddMenuItem(aboutUs);
            homeMenu.Display(0);
        }
    }
  
}
