using Root;
using UnityEngine;

namespace Models
{
    public class TutorialScreen : BaseScreen
    {
        public override void Initialize()
        {
            base.Initialize();
            
        }

        public void StartTutorial()
        {
            gameObject.SetActive(true);
            ShowScreen();
        }
    }
}
