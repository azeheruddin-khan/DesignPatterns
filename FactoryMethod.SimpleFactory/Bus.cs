namespace FactoryMethod.SimpleFactory
{
    public class Bus : IVehicle
    {
        string Name = "Bus";
        public void Model()
        {
            Console.WriteLine("Name:" + Name + " Model()");
        }

        public void Speed()
        {
            Console.WriteLine("Name:" + Name + " Speed()");
        }
    }
}
