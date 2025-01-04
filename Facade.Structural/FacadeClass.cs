namespace Facade.Structural
{
    public class FacadeClass
    {
        private Subsystem1 subsystem1 = new Subsystem1();
        private Subsystem2 subsystem2 = new Subsystem2();
        private Subsystem3 subsystem3 = new Subsystem3();

        public void FacadeMethod()
        {
            subsystem1.Method1();
            subsystem2.Method1();
            subsystem3.Method1();
        }


    }
}
