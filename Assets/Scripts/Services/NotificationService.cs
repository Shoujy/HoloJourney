using Root;
using UnityEngine;

namespace Services
{
    public class NotificationService : IService
    {
        private GameObject _alertPrefab;
        private GameObject _popupPrefab;
        
        public void Initialize()
        {
            Debug.LogFormat($"{GetType()} initialized!");
        }

        public void ShutDown()
        {
        
        }

        public void ShowAlert(string message)
        {
            
        }

        public void ShowPopup(string message)
        {
            
        }
    }
}
