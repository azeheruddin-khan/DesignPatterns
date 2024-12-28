namespace Builder.RealtimeExample
{
    public class Laptop
    {
        private List<string> _parts = new List<string>();

        public void AddParts(string Parts)
        {
            _parts.Add(Parts);
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
