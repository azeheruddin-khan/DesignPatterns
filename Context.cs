namespace Strategy.Structural
{
    public class Context
    {
        private List<string> lst=  new List<string>();
        public void AddItems(string item)
        {
            lst.Add(item);
        }
        Strategy strategy;
        public Context(Strategy strategy) {
            this.strategy = strategy;
        
        }

        public void Sort()
        {
            strategy.Sort(lst);
        }

    }
}
