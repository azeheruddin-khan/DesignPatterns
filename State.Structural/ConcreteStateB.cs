namespace State.Structural
{
    public class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
            Console.WriteLine(this.GetType().Name);
        }
    }
}
