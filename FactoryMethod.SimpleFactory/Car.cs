namespace FactoryMethod.SimpleFactory
{
    public class Car : IVehicle
    {
        string Name = "Car";
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
