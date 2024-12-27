namespace Prototype.Structural
{
    public abstract class Prototype
    {
        string id;

        public Prototype(string id)
        {
            this.id = id;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public abstract Prototype Clone();
    }
}
