using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundHandler : MonoBehaviour
{
    public AudioClip sceneAmbientSound;


    void Awake()
    {
        
        if (TryGetComponent<AudioSource>(out var audioSource))
        {
            audioSource.clip = sceneAmbientSound;
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("AudioSource component not founded" + gameObject.name);
        }
        
    }

    
}
