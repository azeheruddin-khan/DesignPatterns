namespace Visitor.Structural
{
    internal partial class Program
    {
        public interface IElement
        {
            public void Accept(IVisitor visitor);
        }



    }
}
