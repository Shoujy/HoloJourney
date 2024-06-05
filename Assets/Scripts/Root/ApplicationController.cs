using System;
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
            var user = FetchUserData();

            if (user.isNew)
            {
                sceneManager.LoadScene(StringsHolder.onboardingScene);
            }
            else
            {
                sceneManager.LoadScene(StringsHolder.mainMenuScene);
            }
        }

        private void SetupServices()
        {
            var assetService = new AssetService();
            assetService.Initialize();
            ServicesHolder.Instance.AddService(assetService.GetType().ToString(), assetService);
            
            var sceneService = new SceneService();
            sceneService.Initialize();
            ServicesHolder.Instance.AddService(sceneService.GetType().ToString(), sceneService);
            
            var notificationService = new NotificationService();
            notificationService.Initialize();
            ServicesHolder.Instance.AddService(notificationService.GetType().ToString(), notificationService);
            
            var userDataService = new UserDataService();
            userDataService.Initialize();
            ServicesHolder.Instance.AddService(userDataService.GetType().ToString(), userDataService);
            
            var eventService = new EventService();
            eventService.Initialize();
            ServicesHolder.Instance.AddService(eventService.GetType().ToString(), eventService);
        }

        private User FetchUserData()
        {
            var userDataService = ServicesHolder.Instance.GetService<UserDataService>();
            return userDataService.GetUserData();
        }
    }
}

