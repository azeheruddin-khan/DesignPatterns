namespace TemplateMethod.Structural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractClass concreateClassA = new ConcreteClassA();
            concreateClassA.TemplateMethod();

            AbstractClass concreateClassB = new ConcreteClassB();
            concreateClassB.TemplateMethod();
        }
    }
}
