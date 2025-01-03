namespace Command.Structural
{
    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
