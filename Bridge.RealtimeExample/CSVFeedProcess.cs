namespace Bridge.RealtimeExample
{
    public class CSVFeedProcess : IFeedProcess
    {
        public void BulkUpdate()
        {
            Console.WriteLine("BulkUpdate()");
        }

        public void DownloadFeedFile()
        {
            Console.WriteLine("DownloadFeedFile()");
        }

        public void GetFeedFileInfo()
        {
            Console.WriteLine("GetFeedFileInfo()");
        }

        public void ProcessFeeFile()
        {
            Console.WriteLine("ProcessFeeFile()");
        }

        public void SendNotification()
        {
            Console.WriteLine("SendNotification()");
        }

        public void TrackInformation()
        {
            Console.WriteLine("TrackInformation()");
        }

        public void ValidateFeedFile()
        {
            Console.WriteLine("ValidateFeedFile()");
        }
    }
}
