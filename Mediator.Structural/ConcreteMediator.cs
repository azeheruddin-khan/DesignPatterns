namespace Mediator.Structural
{
    public class ConcreteMediator : Mediator
    {
        private ConcreteColleague2 concreteColleague2;
        private ConcreteColleague1 concreteColleague1;
       

        public ConcreteColleague2 ConcreteColleague2
        {
            set { concreteColleague2 = value;}
        }

        public ConcreteColleague1 ConcreteColleague1
        {
            set { concreteColleague1 = value; }
        }

        public override void Send(string message, Colleague colleague)
        {
            if(colleague == concreteColleague1)
            {
                concreteColleague2.Notify(message);
            }
            else
            {
                concreteColleague1.Notify(message);
            }
        }
    }

}
