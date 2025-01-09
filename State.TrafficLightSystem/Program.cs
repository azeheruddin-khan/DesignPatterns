namespace State.TrafficLightSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight();
            trafficLight.ChangeState();
            trafficLight.DisplayState();

            trafficLight.ChangeState();
            trafficLight.DisplayState();

            trafficLight.ChangeState();
            trafficLight.DisplayState();
        }
    }
}

