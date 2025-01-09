namespace State.TrafficLightSystem
{
    public class Green : ITrafficLightState
    {
        public void DisplayState()
        {
            Console.WriteLine("Green Light");
        }
        public void Handle(TrafficLight trafficLight)
        {
            Console.WriteLine("Green Light - Red Light");
            trafficLight.SetState(new Red()) ;
        }
    }



}

