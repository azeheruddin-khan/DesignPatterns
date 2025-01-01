namespace Flyweight.Structural
{
    public class FlyweightFactory
    {
        private Dictionary<string, Flyweight> flyweights = new Dictionary<string, Flyweight>();

        public FlyweightFactory()
        {
            flyweights.Add("x", new ConcreteFlyweight());
            flyweights.Add("y", new ConcreteFlyweight());
            flyweights.Add("z", new ConcreteFlyweight());
        }

        public Flyweight GetFlyweight(string key)
        {
            return flyweights[key];
        }

    }
}
