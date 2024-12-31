namespace Bridge.RealtimeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Feed csvFeed = new CSVFeed(new CSVFeedProcess());
            csvFeed.Process();
        }
    }
}
