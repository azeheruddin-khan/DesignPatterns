namespace FactoryMethod.Structural
{
    internal class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ProductA();
        }
    }
}
