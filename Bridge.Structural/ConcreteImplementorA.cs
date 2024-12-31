namespace Bridge.Structural
{
    public class ConcreteImplementorA : Implementor
    {
        public override void Process()
        {
           Console.WriteLine(this.GetType().Name);
        }
    }
}
