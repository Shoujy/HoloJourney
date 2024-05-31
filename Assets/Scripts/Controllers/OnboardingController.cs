using Models;
using UnityEngine;

namespace Controllers
{
    public class OnboardingController : MonoBehaviour
    {
        [SerializeField] private OnboardingScreen onboardingScreen;
        [SerializeField] private TutorialScreen tutorialScreen;

        public void Initialize()
        {
            onboardingScreen.Initialize();
            tutorialScreen.Initialize();
            
            tutorialScreen.HideScreen();
            onboardingScreen.ShowScreen();

            onboardingScreen.onOnboardingFinish += StartTutorial;
        }
        
        private void Start()
        {
            Initialize();
        }

        private void StartTutorial()
        {
            onboardingScreen.HideScreen();
            tutorialScreen.StartTutorial();
        }

        private void OnDestroy()
        {
            onboardingScreen.onOnboardingFinish -= StartTutorial;
        }
    }
}
