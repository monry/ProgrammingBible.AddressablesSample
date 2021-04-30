using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

namespace ProgrammingBible.AddressablesSample
{
    public class CharacterImage : MonoBehaviour
    {
        public int Index;
        public RawImage RawImage;
        public List<AssetReferenceTexture2D> Textures;

        void Start()
        {
            StartCoroutine(LoadTexture());
        }

        IEnumerator LoadTexture()
        {
            var assetReference = Textures[Index];
            var asyncOperation = assetReference.LoadAssetAsync();
            while (!asyncOperation.IsDone)
            {
                yield return null;
            }

            RawImage.texture = asyncOperation.Result;
            RawImage.SetNativeSize();
            RawImage.color = Color.white;
        }
    }
}