using Root;
using UnityEngine;

namespace Managers
{
    public class UIManager : IManager
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
