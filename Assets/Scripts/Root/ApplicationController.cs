using Services;
using UnityEngine;

namespace Root
{
    public class ApplicationController : MonoBehaviour
    {
        private void Start()
        {
            SetupServices();

            var sceneManager = ServicesHolder.Instance.GetService<SceneService>();
            sceneManager.LoadScene("Onboarding");
        }

        private void SetupServices()
        {
            var assetManager = new AssetService();
            assetManager.Initialize();
            ServicesHolder.Instance.AddService(assetManager.GetType().ToString(), assetManager);
            
            var sceneManager = new SceneService();
            sceneManager.Initialize();
            ServicesHolder.Instance.AddService(sceneManager.GetType().ToString(), sceneManager);
            
            var uiManager = new UIService();
            uiManager.Initialize();
            ServicesHolder.Instance.AddService(uiManager.GetType().ToString(), uiManager);
            
            var stateManager = new StateService();
            stateManager.Initialize();
            ServicesHolder.Instance.AddService(stateManager.GetType().ToString(), stateManager);
            
            var eventManager = new EventService();
            eventManager.Initialize();
            ServicesHolder.Instance.AddService(eventManager.GetType().ToString(), eventManager);
        }
    }
}

