namespace State.TrafficLightSystemWithFactoryMethod
{
    public class TrafficLight
    {
        private ITrafficLightState trafficLightState;
        public TrafficLight()
        {
            trafficLightState = TrafficLightStateFactory.CreateTrafficLightState(TrafficLightColor.Red);
        }
        public void SetState(ITrafficLightState trafficLightState)
        {
            this.trafficLightState = trafficLightState;
        }
        public void ChangeState()
        {
            this.trafficLightState.Handle(this);
        }
        public void DisplayState()
        {
            this.trafficLightState.DisplayState();
        }
    }
}
