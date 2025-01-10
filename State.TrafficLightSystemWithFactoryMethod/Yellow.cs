namespace State.TrafficLightSystemWithFactoryMethod
{
    public class Yellow : ITrafficLightState
    {
        public void DisplayState()
        {
            Console.WriteLine("Yellow Light");
        }
        public void Handle(TrafficLight trafficLight)
        {
            Console.WriteLine("Yellow Light - Green Light");
            trafficLight.SetState(TrafficLightStateFactory.CreateTrafficLightState(TrafficLightColor.Green));
        }
    }
}
