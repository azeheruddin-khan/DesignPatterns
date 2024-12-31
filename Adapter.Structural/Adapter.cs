namespace Adapter.Structural
{
    public class Adapter : ITarget
    {
        private Adaptee _adaptee;
        public Adapter()
        {
            _adaptee = new Adaptee();
        }

        public void Process()
        {
            _adaptee.SpecificProcess();
        }
    }
}
