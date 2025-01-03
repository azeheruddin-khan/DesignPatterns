 namespace Command.Structural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker(command);
            invoker.Invoke();
        }
    }
}
