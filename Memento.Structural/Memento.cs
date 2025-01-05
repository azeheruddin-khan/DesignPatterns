namespace Memento.Structural
{
    public class Memento
    {
        string state;
        public Memento(String state)
        {
            this.state = state;
        }
        

        public string State
        {
            get { return this.state; }
        }

    }
}
