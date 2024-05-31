using System.Collections.Generic;
using Models;
using UnityEngine;

namespace Controllers
{
    public class BottomBarController : MonoBehaviour
    {
        [SerializeField] private List<MenuButton> menuButtons;
        [SerializeField] private List<GameObject> menuScreens;

        public void Start()
        {
            Initialize();
        }

        public void Initialize()
        {
            for (int i = 0; i < menuButtons.Count; i++)
            {
                menuButtons[i].Initialize(i, Interact);
                menuButtons[i].Activate();
                menuScreens[i].SetActive(false);
            }
            
            Interact(0);
        }

        private void Interact(int id)
        {
            menuButtons.ForEach(element => element.Activate());
            menuScreens.ForEach(element => element.SetActive(false));
            menuButtons[id].Deactivate();
            menuScreens[id].SetActive(true);
        }
    }
}
