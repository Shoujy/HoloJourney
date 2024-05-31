using System;
using Root;
using UnityEngine;

namespace Managers
{
    public enum HoloStates
    {
        Bootstrap = 0,
        Onboarding,
        Menu,
        Play,
        Pause
    }
    
    public class StateManager : IManager
    {
        private HoloStates _currentState;

        public void Initialize()
        {
            _currentState = HoloStates.Bootstrap;
            Debug.LogFormat($"{GetType()} initialized!");
        }

        public void ShutDown()
        {
            
        }

        public HoloStates GetCurrentState()
        {
            return _currentState;
        }
    }
}
