namespace Bridge.Structural
{
    public class ConcreteImplementorB : Implementor
    {
        public override void Process()
        {
           Console.WriteLine(this.GetType().Name);
        }
    }
}
