namespace Visitor.Structural
{
    internal partial class Program
    {
        public class ConcreteVisitor1 : IVisitor
        {
            public void Visit(IElement element)
            {

                Console.WriteLine("Visited element - " + element.GetType().Name);
            }
        }



    }
}
