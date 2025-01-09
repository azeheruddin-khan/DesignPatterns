namespace State.TrafficLightSystem
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
            trafficLight.SetState(new Yellow());
        }
    }



}

