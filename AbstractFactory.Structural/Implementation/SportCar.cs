using AbstractFactory.Structural.Interface;

namespace AbstractFactory.Structural.Implementation
{
    public class SportCar : ICar
    {
        public void GetDatails()
        {
            Console.WriteLine("Sport Car");
        }
    }
}
