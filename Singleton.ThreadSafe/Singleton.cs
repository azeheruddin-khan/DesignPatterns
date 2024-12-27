namespace Singleton.ThreadSafe
{
    public class Singleton
    {
        private static Singleton instance;
        private static object instanceLock = new object();
        private Singleton()
        {
        }
        public static Singleton Instance()
        {
            if(instance == null)
            {
                lock (instanceLock)
                {
                    if(instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }
    }
}
