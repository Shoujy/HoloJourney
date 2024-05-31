using System;
using Root;
using UnityEngine;

namespace Managers
{
    public class EventManager : IManager
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
