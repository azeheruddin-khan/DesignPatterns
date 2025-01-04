namespace State.Structural
{
    public class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
            Console.WriteLine(this.GetType().Name);
        }
    }
}
