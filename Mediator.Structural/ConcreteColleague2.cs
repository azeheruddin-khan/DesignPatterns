namespace Mediator.Structural
{
    public class ConcreteColleague2:Colleague
    {
        public ConcreteColleague2(Mediator mediator):base(mediator)
        {
            
        }

        public void Send(string message)
        {
            Console.WriteLine(this.GetType().Name + " - " + message);
            mediator.Send(message, this);

        }

        public void Notify(string message)
        {
            Console.WriteLine(new String('-', 2) + " " + this.GetType().Name + " - " + message);
        }



    }

}
