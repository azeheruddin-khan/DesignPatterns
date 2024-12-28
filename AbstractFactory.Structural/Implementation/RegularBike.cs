using AbstractFactory.Structural.Interface;

namespace AbstractFactory.Structural.Implementation
{
    public class RegularBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Regular Car");
        }
    }
}
