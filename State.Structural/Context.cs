namespace State.Structural
{
    public class Context
    {
        private State state;
        public Context(State state)
        {
            this.state = state;
        }

        public State State
        {
            get { return state; }
            set { state = value; }
        }

        public void Request()
        {
            state.Handle(this);
        }

    }
}
