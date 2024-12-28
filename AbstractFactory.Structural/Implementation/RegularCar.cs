using AbstractFactory.Structural.Interface;

namespace AbstractFactory.Structural.Implementation
{
    public class RegularCar : ICar
    {
        public void GetDatails()
        {
            Console.WriteLine("Regular Car");
        }
    }
}
