namespace State.TrafficLightSystemWithFactoryMethod
{
    public class Red : ITrafficLightState
    {
        public void DisplayState()
        {
            Console.WriteLine("Red Light");
        }
        public void Handle(TrafficLight trafficLight)
        {
            Console.WriteLine("Red Light - Yellow Light");
            trafficLight.SetState(TrafficLightStateFactory.CreateTrafficLightState(TrafficLightColor.Yellow));
        }
    }
}
