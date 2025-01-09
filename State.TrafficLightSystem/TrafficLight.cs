namespace State.TrafficLightSystem
{
    public class TrafficLight
    {
        private ITrafficLightState trafficLightState;
        public TrafficLight()
        {
            trafficLightState = new Red();
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

