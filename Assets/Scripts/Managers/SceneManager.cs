using Root;
using UnityEngine;

namespace Managers
{
    public class SceneManager : IManager
    {
        public void Initialize()
        {
            Debug.LogFormat($"{GetType()} initialized!");
        }

        public void ShutDown()
        {
        
        }

        public void LoadScene(string sceneName)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        }
    }
}