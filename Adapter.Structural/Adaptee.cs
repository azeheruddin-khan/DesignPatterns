namespace Adapter.Structural
{
    public class Adaptee
    {
       public Adaptee() { }
       public void SpecificProcess()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
