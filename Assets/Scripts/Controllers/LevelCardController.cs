using System;
using Services;
using Root;
using UnityEngine;
using UnityEngine.UI;

namespace Controllers
{
    public class LevelCardController : MonoBehaviour
    {
        [SerializeField] private Button cardButton;
    
        [SerializeField] private Button infoButton;
        [SerializeField] private GameObject infoPanel;

        [SerializeField] private string levelSceneName;
        
        public void Initialize()
        {
            cardButton.onClick.AddListener(OpenLevel);
            infoButton.onClick.AddListener(OpenInfoPanel);
        }
        
        private void Start()
        {
            Initialize();
        }

        private void OpenLevel()
        {
           var sceneManager = ServicesHolder.Instance.GetService<SceneService>();

           if (sceneManager == null)
           {
               Debug.LogFormat($"[{GetType()}][OpenLevel] sceneManager is null!");
               return;
           }
           
           sceneManager.LoadScene(levelSceneName);
        }

        private void OpenInfoPanel()
        {
            if (infoPanel.activeSelf)
            {
                cardButton.interactable = true;
                infoPanel.SetActive(false);
                return;
            }

            cardButton.interactable = false;
            infoPanel.SetActive(true);
        }

        private void OnDestroy()
        {
            cardButton.onClick.RemoveListener(OpenLevel);
            infoButton.onClick.RemoveListener(OpenInfoPanel);
        }
    }
}
