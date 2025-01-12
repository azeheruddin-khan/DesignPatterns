namespace TemplateMethod.ETLProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FeedPrcoess csvFeedPrcoess = new CSVFeedProcess();
            csvFeedPrcoess.Execute();

            FeedPrcoess xmlFeedPrcoess = new XMLFeedProcess();
            xmlFeedPrcoess.Execute();
        }
    }
}
