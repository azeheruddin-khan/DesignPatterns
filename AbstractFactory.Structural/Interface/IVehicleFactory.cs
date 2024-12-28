namespace AbstractFactory.Structural.Interface
{
    public interface IVehicleFactory
    {
        IBike CreateBike();
        ICar CreateCar();
         
    }
}
