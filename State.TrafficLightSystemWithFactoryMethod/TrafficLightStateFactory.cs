namespace State.TrafficLightSystemWithFactoryMethod
{
    public static class TrafficLightStateFactory
    {
        private static Dictionary<TrafficLightColor, ITrafficLightState> trafficLightStateDic = 
            new Dictionary<TrafficLightColor, ITrafficLightState>();
        static TrafficLightStateFactory()
        {
            trafficLightStateDic.Add(TrafficLightColor.Red, new Red());
            trafficLightStateDic.Add(TrafficLightColor.Green, new Green());
            trafficLightStateDic.Add(TrafficLightColor.Yellow, new Yellow());
        }

        public static ITrafficLightState CreateTrafficLightState(TrafficLightColor trafficLightColor)
        {
            return trafficLightStateDic[trafficLightColor];
        }
    }
}
