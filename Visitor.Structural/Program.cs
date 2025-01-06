namespace Visitor.Structural
{
    internal partial class Program
    {
        static void Main(string[] args)
        {

            Context context = new Context();
            context.Add(new ConcreteElement1());
            context.Add(new ConcreteElement2());
            context.Add(new ConcreteElement3());

            IVisitor visitor = new ConcreteVisitor1();

            foreach ( var element in context.Elements)
            {
                element.Accept(visitor);
            }         

        }
    }
}
