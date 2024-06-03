using Root;
using UnityEngine;

namespace Services
{
    public class AssetService : IService
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
