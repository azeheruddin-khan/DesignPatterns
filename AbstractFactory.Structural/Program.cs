using AbstractFactory.Structural.Implementation;
using AbstractFactory.Structural.Interface;

namespace AbstractFactory.Structural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicleFactory regularVehicleFactory = new RegularFactory();
            ICar car = regularVehicleFactory.CreateCar();
            IBike bike = regularVehicleFactory.CreateBike();

            car.GetDatails();
            bike.GetDetails();


            IVehicleFactory sportVehicleFactory = new SportFactory();
            ICar sportCar = sportVehicleFactory.CreateCar();
            IBike sportBike = sportVehicleFactory.CreateBike();

            sportCar.GetDatails();
            sportBike.GetDetails();


        }
    }
}
