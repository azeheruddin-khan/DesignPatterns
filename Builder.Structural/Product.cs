namespace Builder.Structural
{
    public class Product
    {
        private List<string> _parts = new List<string>();
        public Product() { }
        public void AddPart(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            foreach (var part in _parts)
            {
                Console.WriteLine(part);
            }
        }

    }
}
