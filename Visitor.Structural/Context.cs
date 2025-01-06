namespace Visitor.Structural
{
    internal partial class Program
    {
        public class Context
        {
            private List<IElement> elements;

            public Context()
            {
                    elements = new List<IElement>();
            }

            public void Add(IElement element)
            {
                elements.Add(element);
            }

            public IEnumerable<IElement> Elements { get { return elements; } }

        }



    }
}
