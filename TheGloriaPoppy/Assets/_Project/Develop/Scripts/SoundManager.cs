using UnityEngine;

namespace _Project.Develop.Scripts
{
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager Instance;

        public AudioSource audioSource;

        [Header("Sounds")]
        public AudioClip hitSound;
        public AudioClip deathSound;
        public AudioClip pickupSound;

        void Awake()
        {
            Instance = this;
        }

        public void PlaySound(AudioClip clip)
        {
            audioSource.PlayOneShot(clip);
        }
    }
}