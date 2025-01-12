namespace TemplateMethod.ETLProcess
{
    public class XMLFeedProcess : FeedPrcoess
    {
        public override void Start()
        {
            Console.WriteLine("Start - Download file/Connect SFTP folder");
        }

        public override void ValidateFile()
        {
            Console.WriteLine("ValidateFile -  Check file format/Data");
        }
        public override void ProcessFile()
        {
            Console.WriteLine("ProcessFile -  Save data into DB");
        }
        public override void BackupFile()
        {
            Console.WriteLine("BackupFile - Move file to backup folder");
        }       

        public override void Notification()
        {
            Console.WriteLine("Notification - Send email");
        }

        public override void End()
        {
            Console.WriteLine("End - Update all the status");
        }
    }
}
