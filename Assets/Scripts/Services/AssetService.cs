using System;
using Cysharp.Threading.Tasks;
using Root;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Services
{
    public class AssetService : IService
    {
        public void Initialize()
        {
            Debug.LogFormat($"{GetType()} initialized!");
        }

        public void ShutDown()
        {
        
        }

        public async UniTask<T> LoadResourceDataAsync<T>(string name) where T : Object
        {
            return await GetResourceAsync<T>(name);
        }
        
        public async UniTask<GameObject> LoadGameObjectAsync(string name)
        {
            return await GetResourceAsync<GameObject>(name);
        }
        
        private async UniTask<T> GetResourceAsync<T>(string name) where T : Object
        {
            try
            {
                var locations = await UnityEngine.AddressableAssets.Addressables.LoadResourceLocationsAsync(name).Task;
                return await UnityEngine.AddressableAssets.Addressables.LoadAssetAsync<T>(locations[0]).Task;
            }
            catch (Exception exception)
            {
                Debug.LogWarningFormat("[{0}][GetResourceAsync]Resource \"{1}\" loading error - {2}", GetType().Name, name, exception);
                return null;
            }
        }
    }
}
