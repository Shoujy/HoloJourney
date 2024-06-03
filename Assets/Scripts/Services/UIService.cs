using Root;
using UnityEngine;

namespace Services
{
    public class UIService : IService
    {
        public void Initialize()
        {
            Debug.LogFormat($"{GetType()} initialized!");
        }

        public void ShutDown()
        {
        
        }
    }
}
