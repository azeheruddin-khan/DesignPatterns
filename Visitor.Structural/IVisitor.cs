namespace Visitor.Structural
{
    internal partial class Program
    {
        public interface IVisitor
        {
            public void Visit(IElement element);
        }



    }
}
