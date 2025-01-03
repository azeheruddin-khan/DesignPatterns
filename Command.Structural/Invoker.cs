namespace Command.Structural
{
    public class Invoker
    {
        private Command command;
        public Invoker(Command command)
        {
            this.command = command;

        }

        public void Invoke()
        {
            command.Execute();
        }
    }
}
