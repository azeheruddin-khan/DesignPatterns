namespace Builder.Fluent
{
    public class Laptop
    {
        private List<string> parts = new List<string>();

        public void AddPart(string part)
        {
            parts.Add(part);
        }
        public void Show()
        {
            foreach (var part in parts)
            {
                Console.WriteLine(part);
            }

        }
    }
}
