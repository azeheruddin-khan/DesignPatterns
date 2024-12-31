namespace Bridge.Structural
{
    public abstract class Abstraction
    {
        protected Implementor implementor;
        public Abstraction(Implementor implementor)
        {
            this.implementor = implementor;
        }

        public virtual void Opertaion()
        {
            this.implementor.Process();
        }

    }
}
