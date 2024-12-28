using AbstractFactory.Structural.Interface;

namespace AbstractFactory.Structural.Implementation
{
    public class SportBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Sport Bike");
        }
    }
}
