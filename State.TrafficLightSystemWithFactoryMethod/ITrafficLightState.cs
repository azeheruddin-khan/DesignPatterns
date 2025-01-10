namespace State.TrafficLightSystemWithFactoryMethod
{
    public interface ITrafficLightState
    {
        void Handle(TrafficLight trafficLight);
        void DisplayState();
    }
}
