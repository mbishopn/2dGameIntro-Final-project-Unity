using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [SerializeField] AudioSource MusicHolder;
    [SerializeField] AudioSource sfxHolder;


    public AudioClip backgroundMusic;


    private void Start()
    {
        MusicHolder.clip = backgroundMusic;
        MusicHolder.Play();
    }

}
