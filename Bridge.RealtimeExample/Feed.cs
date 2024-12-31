namespace Bridge.RealtimeExample
{
    public abstract class Feed
    {
        protected IFeedProcess feedProcess;
        public Feed(IFeedProcess feedProcess)
        {
            this.feedProcess = feedProcess;
        }
        public virtual void Process()
        {
            this.feedProcess.GetFeedFileInfo();
            this.feedProcess.DownloadFeedFile();
            this.feedProcess.ValidateFeedFile();
            this.feedProcess.ProcessFeeFile();
            this.feedProcess.BulkUpdate();
            this.feedProcess.TrackInformation();
            this.feedProcess.SendNotification();
        }
    }    
}
