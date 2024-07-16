using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace Zenject.Tests.IntegrationTests.Async.Addressable
{
    public class AddressableTestUtils
    {
        public static IEnumerator GetAddressableReference(string key, Action<AssetReferenceGameObject> onFound)
        {
            AsyncOperationHandle<IList<IResourceLocation>> locationsHandle;
            try
            {
                locationsHandle = Addressables.LoadResourceLocationsAsync(key);
            }
            catch (Exception e)
            {
                Assert.Inconclusive("You need to set TestAddressablePrefab key to run this test");
                yield break;
            }
        
            while (!locationsHandle.IsDone)
            {
                yield return null;
            }

            var locations = locationsHandle.Result;
            if (locations == null || locations.Count == 0)
            {
                Assert.Inconclusive("You need to set TestAddressablePrefab key to run this test");
            }

            var resourceLocation = locations[0];

            if (resourceLocation.ResourceType != typeof(GameObject))
            {
                Assert.Inconclusive("TestAddressablePrefab should be a GameObject");
            }

            onFound?.Invoke(new AssetReferenceGameObject(resourceLocation.PrimaryKey));
        }
    }
}