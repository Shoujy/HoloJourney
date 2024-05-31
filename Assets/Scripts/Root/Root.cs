using Managers;
using UnityEngine;

namespace Root
{
    public class Root : MonoBehaviour
    {
        private void Start()
        {
            SetupManagers();

            var sceneManager = ManagersHolder.Instance.GetManager<SceneManager>();
            sceneManager.LoadScene("Onboarding");
        }

        private void SetupManagers()
        {
            var assetManager = new AssetManager();
            assetManager.Initialize();
            ManagersHolder.Instance.AddManager(assetManager.GetType().ToString(), assetManager);
            
            var sceneManager = new SceneManager();
            sceneManager.Initialize();
            ManagersHolder.Instance.AddManager(sceneManager.GetType().ToString(), sceneManager);
            
            var uiManager = new UIManager();
            uiManager.Initialize();
            ManagersHolder.Instance.AddManager(uiManager.GetType().ToString(), uiManager);
            
            var stateManager = new StateManager();
            stateManager.Initialize();
            ManagersHolder.Instance.AddManager(stateManager.GetType().ToString(), stateManager);
            
            var eventManager = new EventManager();
            eventManager.Initialize();
            ManagersHolder.Instance.AddManager(eventManager.GetType().ToString(), eventManager);
        }
    }
}

