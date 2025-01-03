namespace FactoryMethod.SimpleFactory
{
    public static class VehicleFactory
    {
        private static readonly Dictionary<VehicleType, IVehicle> vehicleTypeDic = new Dictionary<VehicleType, IVehicle>();

        static VehicleFactory()
        {
            vehicleTypeDic.Add(VehicleType.Car, new Car());
            vehicleTypeDic.Add(VehicleType.Bus, new Bus());
            vehicleTypeDic.Add(VehicleType.Truck, new Truck());
        }

        public static IVehicle CreateVehicle(VehicleType type)
        {
            return vehicleTypeDic[type];
        }
    }
}
