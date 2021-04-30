using UnityEngine;

namespace ProgrammingBible.AddressablesSample
{
    public class Character : MonoBehaviour
    {
        public CharacterImage CharacterImage;
        public CharacterVoice CharacterVoice;

        void Awake()
        {
            var index = Random.Range(0, 3);
            CharacterImage.Index = index;
            CharacterVoice.Index = index;
        }
    }
}