using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

namespace ProgrammingBible.AddressablesSample
{
    public class CharacterVoice : MonoBehaviour
    {
        public int Index;
        public AudioSource AudioSource;
        public Button PlayButton;
        public List<AssetReferenceT<AudioClip>> AudioClips;

        void Start()
        {
            StartCoroutine(LoadAudioClip());
        }

        IEnumerator LoadAudioClip()
        {
            var assetReference = AudioClips[Index];
            var asyncOperation = assetReference.LoadAssetAsync();
            while (!asyncOperation.IsDone)
            {
                yield return null;
            }

            AudioSource.clip = asyncOperation.Result;
            PlayButton.interactable = true;
        }
    }
}