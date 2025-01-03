using static Iterator.Structural.ConcreteAggregate;

namespace Iterator.Structural
{
    public abstract class Aggregate
    {
        public abstract IteratorClass CreateIterator();
    }
}
