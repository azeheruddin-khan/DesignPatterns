namespace FactoryMethod.SimpleFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicle vehicle = VehicleFactory.CreateVehicle(VehicleType.Car);
            vehicle.Model();
            vehicle.Speed();
           
        }
    }
}
