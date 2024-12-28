using AbstractFactory.Structural.Interface;

namespace AbstractFactory.Structural.Implementation
{
    public class SportFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new SportBike();
        }

        public ICar CreateCar()
        {
            return new SportCar();
        }
    }
}
