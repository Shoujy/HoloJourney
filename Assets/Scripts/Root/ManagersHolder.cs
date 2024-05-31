using System.Collections.Generic;

namespace Root
{
    public class ManagersHolder
    {
        private static readonly ManagersHolder _instance = new ManagersHolder();
        private static Dictionary<string, IManager> _managers = new Dictionary<string, IManager>();
        
        private ManagersHolder() { }
        
        public static ManagersHolder Instance => _instance;
        
        public void AddManager(string key, IManager manager)
        {
            _managers.TryAdd(key, manager);
        }

        public void RemoveManager(string key)
        {
            if (_managers.ContainsKey(key))
            {
                _managers[key].ShutDown();
                _managers.Remove(key);
            }
        }

        public T GetManager<T>() where T : IManager
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
