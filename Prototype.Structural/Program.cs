namespace Prototype.Structural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prototype originalCopy = new ConcretePrototype("1235");
            Prototype cloneCopy = originalCopy.Clone();
            cloneCopy.Id = "9999";

            Console.WriteLine("Original Copy ID:"+ originalCopy.Id);
            Console.WriteLine("Clone Copy ID:" + cloneCopy.Id);          

        }
    }
}
