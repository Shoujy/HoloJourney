using Root;
using UnityEngine;

namespace Managers
{
    public class AssetManager : IManager
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
