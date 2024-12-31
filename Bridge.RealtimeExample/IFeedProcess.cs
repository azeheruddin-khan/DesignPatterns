namespace Bridge.RealtimeExample
{
    public interface IFeedProcess
    {
        void GetFeedFileInfo();
        void DownloadFeedFile();
        void ValidateFeedFile();
        void ProcessFeeFile();
        void BulkUpdate();
        void TrackInformation();
        void SendNotification();

    }
}
