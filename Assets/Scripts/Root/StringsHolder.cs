using System.IO;
using UnityEngine;

namespace Root
{
    public static class StringsHolder
    {
        public static string localConfigPath = Path.Combine(Application.persistentDataPath, "localConfig.json");
        public static string onboardingScene = "Onboarding";
        public static string mainMenuScene = "MainMenu";
    }
}
