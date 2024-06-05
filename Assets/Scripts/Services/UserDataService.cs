using System;
using System.Collections.Generic;
using System.IO;
using Helpers;
using Root;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Services
{
    public class UserDataService : IService
    {
        private User _userData;

        public void Initialize()
        {
            if (ReadUserFromConfig(StringsHolder.localConfigPath) == null)
            {
                _userData = new User(Guid.NewGuid());
                SaveUserToConfig(_userData, StringsHolder.localConfigPath);
            }
            else
            {
                _userData = GetUserData();
            }
        }

        public void ShutDown()
        {
            
        }

        public User GetUserData()
        {
            _userData = ReadUserFromConfig(StringsHolder.localConfigPath);

            if (_userData == null)
            {
                Debug.LogWarningFormat($"[{GetType()}][GetUserData] User data not found!");
                return null;
            }
        
            return _userData;
        }

        public Texture2D GetProfilePicture()
        {
            if (_userData != null && !string.IsNullOrEmpty(_userData.profilePicture))
            {
                return ImageHelper.Base64ToTexture2D(_userData.profilePicture);
            }
            return null;
        }

        public void SetProfilePicture(Texture2D texture)
        {
            if (_userData != null)
            {
                _userData.profilePicture = ImageHelper.Texture2DToBase64(texture);
                SaveUserToConfig(_userData, StringsHolder.localConfigPath);
            }
        }

        private User ReadUserFromConfig(string path)
        {
            if (File.Exists(path))
            {
                string jsonContent = File.ReadAllText(path);
                LocalSetupConfig localSetupConfig = JsonUtility.FromJson<LocalSetupConfig>(jsonContent);
                return localSetupConfig.UserData;
            }
            else
            {
                Debug.LogError("File not found: " + path);
                return null;
            }
        }

        private void SaveUserToConfig(User user, string path)
        {
            LocalSetupConfig config = new LocalSetupConfig { UserData = user };
            string jsonContent = JsonUtility.ToJson(config, true);
            File.WriteAllText(path, jsonContent);

            Debug.Log("User data saved to " + path);
        }
    }
}
