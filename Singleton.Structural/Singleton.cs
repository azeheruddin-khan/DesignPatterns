namespace Singleton.Structural
{
    public class Singleton
    {
        private static Singleton instance;

        private Singleton() { }

        public static Singleton Instance()
        {
            if(instance == null)
                instance = new Singleton();
            return instance;
        }
    }
}
