namespace Memento.Structural
{
    public class Originator
    {
        string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public Memento CreateMemento()
        {
            return new Memento(state);
        }

        public void UpdateMemento(Memento memento)
        {
            state = memento.State; 
        }

       
    }
}
