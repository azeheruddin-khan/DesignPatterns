namespace Builder.Structural
{
    public abstract class Builder
    {
        public abstract void AddPartA();
        public abstract void AddPartB();
        public abstract Product GetProduct();

    }
}
