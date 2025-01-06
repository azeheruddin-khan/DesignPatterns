namespace Visitor.Structural
{
    internal partial class Program
    {
        public class ConcreteElement1 : IElement
        {

            public void Accept(IVisitor visitor)
            {
                visitor.Visit(this);
            }

        }



    }
}
