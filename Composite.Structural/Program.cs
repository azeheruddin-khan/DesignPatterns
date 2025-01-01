namespace Composite.Structural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Composite computer = new Composite("Computer");
            Composite motherboard = new Composite("MotherBoard");

            motherboard.AddComponent(new Leaf("Ram"));
            motherboard.AddComponent(new Leaf("CPU"));
            motherboard.AddComponent(new Leaf("Hard Disk"));
            motherboard.AddComponent(new Leaf("CD Rom"));
            computer.AddComponent(motherboard);
            computer.Display(0);
        }
    }
}
