namespace Bridge.RealtimeExample
{
    public class CSVFeed : Feed
    {
        public CSVFeed(IFeedProcess feedProcess) : base(feedProcess)
        {
        }

        public override void Process()
        {
            Console.WriteLine("Stated -  CSVFeed");
            base.Process();
            Console.WriteLine("End -  CSVFeed");
        }
    }
}
