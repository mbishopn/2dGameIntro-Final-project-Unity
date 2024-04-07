using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [Header("--------Audio Source ------------")]

    // Audio Sources
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;
    [Header("---------For Audio Clips:---------")]
    public AudioClip background;
    public AudioClip deathsound;
    public AudioClip Colliding;


    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
        
    }

}

