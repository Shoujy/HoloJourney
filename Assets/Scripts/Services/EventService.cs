using System;
using Root;
using UnityEngine;

namespace Services
{
    public class EventService : IService
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
