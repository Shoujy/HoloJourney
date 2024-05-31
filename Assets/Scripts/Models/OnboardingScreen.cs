using System;
using System.Collections.Generic;
using Root;
using UnityEngine;
using UnityEngine.UI;

namespace Models
{
    public class OnboardingScreen : BaseScreen
    {
        public Action onOnboardingFinish;
        
        [SerializeField] private Button nextButton;
        [SerializeField] private List<GameObject> _texts = new();

        private int _activeTextIndex = 0;

        public override void Initialize()
        {
            base.Initialize();

            nextButton.onClick.AddListener(SwitchScreenText);
        }

        private void SwitchScreenText()
        {
            if (_activeTextIndex + 1 < _texts.Count)
            {
                _texts[_activeTextIndex].SetActive(false);
                
                _activeTextIndex++;
                
                _texts[_activeTextIndex].SetActive(true);
            }
            else
            {
                nextButton.onClick.RemoveAllListeners();
                onOnboardingFinish?.Invoke();
            }
        }
    }
}
