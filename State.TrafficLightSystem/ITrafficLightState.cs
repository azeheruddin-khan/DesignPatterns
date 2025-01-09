namespace State.TrafficLightSystem
{
    public interface ITrafficLightState
    {
        void Handle(TrafficLight trafficLight);
        void DisplayState();
    }



}

