namespace Mediator.Structural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator concreteMediator = new ConcreteMediator();

            ConcreteColleague1 concreteColleague1 = new ConcreteColleague1(concreteMediator);
            ConcreteColleague2 concreteColleague2 = new ConcreteColleague2(concreteMediator);
            concreteMediator.ConcreteColleague1 = concreteColleague1;
            concreteMediator.ConcreteColleague2 = concreteColleague2;

            concreteColleague1.Send("Hi");
            concreteColleague1.Send("How are you");

            concreteColleague2.Send("Hello");
            concreteColleague2.Send("I'm doing good.");
        }
    }

}
