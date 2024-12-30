namespace Proxy.RealtimeExample
{
    public class ProxyService : IService
    {
        private readonly IService _service;
        private readonly Dictionary<string, object> _cache = new Dictionary<string, object>();
        public ProxyService()
        {
            _service = new DataService();

        }
        public object GetData(string key)
        {
            if (_cache.ContainsKey(key))
            {
                Console.WriteLine("Fetching information from cache");
                return _cache[key];
            }

            object result = _service.GetData(key);
            _cache[key] = result;
            return result;
        }
    }
}
