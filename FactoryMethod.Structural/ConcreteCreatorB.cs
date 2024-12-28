namespace FactoryMethod.Structural
{
    public class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ProductB();
        }
    }
}
