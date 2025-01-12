namespace TemplateMethod.ETLProcess
{
    public abstract class FeedPrcoess
    {
        public void Execute()
        {
           Start();
           ValidateFile();
           ProcessFile();
           BackupFile();
           Notification();
           End();

         }

        public abstract void Start();
        public abstract void ValidateFile();
        public abstract void ProcessFile();        
        public abstract void BackupFile();
        public abstract void Notification();
        public abstract void End();
    }
}
