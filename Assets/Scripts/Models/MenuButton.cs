using System;
using UnityEngine;
using UnityEngine.UI;

namespace Models
{
    public class MenuButton : MonoBehaviour
    {
        private Button _button;
        
        private int _id;
        private Action<int> _callback;
        
        public void Initialize(int id, Action<int> callback)
        {
            _button = GetComponentInChildren<Button>();
            
            _id = id;
            _callback = callback;
            
            _button.onClick.AddListener(OnButtonClick);
        }

        public void Activate()
        {
            _button.interactable = true;
        }

        public void Deactivate()
        {
            _button.interactable = false;
        }

        private void OnButtonClick()
        {
            _callback?.Invoke(_id);
        }
    }
}
