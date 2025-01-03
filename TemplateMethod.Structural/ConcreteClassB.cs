namespace TemplateMethod.Structural
{
    public class ConcreteClassB : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine(this.GetType().Name+ " PrimitiveOperation1");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine(this.GetType().Name+ " PrimitiveOperation2");
        }
    }
}
