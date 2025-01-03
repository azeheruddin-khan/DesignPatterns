namespace FactoryMethod.SimpleFactory
{
    public class Truck : IVehicle
    {
        string Name = "Truck";
        public void Model()
        {
            Console.WriteLine("Name:" + Name + "Called Method Model()");
        }

        public void Speed()
        {
            Console.WriteLine("Name:" + Name + "Called Method Speed()");
        }
    }
}
