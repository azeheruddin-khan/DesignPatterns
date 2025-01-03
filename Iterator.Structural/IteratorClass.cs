namespace Iterator.Structural
{
    public abstract class IteratorClass
    {
        public abstract object First();
        public abstract object Next();
        public abstract object Previous();
        public abstract object Current();
        public abstract bool IsDone();
    }
}
