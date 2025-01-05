using System.Globalization;

namespace Memento.Structural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            originator.State = "On";
            Console.WriteLine("Initial State :"+originator.State);

            CareTaker careTaker = new CareTaker();
            careTaker.Memento = originator.CreateMemento();
            originator.State = "Off";
            Console.WriteLine("Updated State :" + originator.State);

            originator.UpdateMemento(careTaker.Memento);
            Console.WriteLine("Rolled Back the State to initial value :" + originator.State);

        }
    }
}
