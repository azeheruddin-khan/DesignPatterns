namespace Iterator.Structural
{
    public class ConcreteAggregate : Aggregate
    {
        private List<object> Items = new List<object>();

        public override IteratorClass CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return Items.Count; }
        }

        public object this[int index]
        {
            get { return Items[index]; }
            set { this.Items.Insert(index, value); }
        }
    }
}
