namespace Iterator.Structural
{
    public class ConcreteIterator : IteratorClass
    {
        ConcreteAggregate aggregate;
        int current = 0;
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;

        }
        public override object Current()
        {
            return this.aggregate[current];
        }

        public override object First()
        {
            return this.aggregate[0];
        }

        public override bool IsDone()
        {
            return current == this.aggregate.Count - 1;
        }

        public override object Next()
        {
            object ret = null;
            if (current < this.aggregate.Count - 1)
            {

                return this.aggregate[current++];


            }
            return ret;

        }

        public override object Previous()
        {
            object ret = null;
            if (current > 0)
            {

                return this.aggregate[current--];


            }
            return ret;
        }
    }
}
