namespace Proxy.RealtimeExample
{
    public class DataService : IService
    {
        public object GetData(string key)
        {
            Console.WriteLine("Fetching data for key: " + key);
            //Fetch information from DB and load to object
            return new object();
        }
    }
}
