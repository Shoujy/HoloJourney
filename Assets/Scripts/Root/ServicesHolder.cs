using System.Collections.Generic;

namespace Root
{
    public class ServicesHolder
    {
        private static readonly ServicesHolder _instance = new ServicesHolder();
        private static Dictionary<string, IService> _managers = new Dictionary<string, IService>();
        
        private ServicesHolder() { }
        
        public static ServicesHolder Instance => _instance;
        
        public void AddService(string key, IService service)
        {
            _managers.TryAdd(key, service);
        }

        public void RemoveService(string key)
        {
            if (_managers.ContainsKey(key))
            {
                _managers[key].ShutDown();
                _managers.Remove(key);
            }
        }

        public T GetService<T>() where T : IService
        {
            var key = typeof(T).ToString();
            if (_managers.ContainsKey(key))
            {
                return (T)_managers[key];
            }

            return default(T);
        }
    }
}
