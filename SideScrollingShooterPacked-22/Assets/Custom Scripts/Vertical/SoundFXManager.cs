using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFXManager : MonoBehaviour
{
    
    public static SoundFXManager instance;

    [SerializeField] private AudioSource soundFXObject;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            
        }
    }


    public void PlaySoundFX(AudioClip clip, Transform spawnTransform, float volume)
    {
        AudioSource soundFX = Instantiate(soundFXObject, transform.position, Quaternion.identity);
        soundFX.clip = clip;
        soundFX.volume = volume;
        soundFX.Play();

        float clipLength = soundFX.clip.length;

        Destroy(soundFX.gameObject, clipLength);
    }

}
