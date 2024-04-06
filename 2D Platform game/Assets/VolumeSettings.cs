using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider;
    /*[SerializeField] private Text volumeTextUI;*/


    private void Start()
    {
        loadValues();
    }
   /* public void VolumeSlider(float volume)
    {
        volumeTextUI.text = volume.ToString("0.0");
    }*/


    public void saveVolumeButton()
    {
        float volumeValue = volumeSlider.value;
        PlayerPrefs.SetFloat("VolumeValue", volumeValue);
        loadValues();
    }

    private void loadValues()
    {
        float volumeValue = PlayerPrefs.GetFloat("VolumeValue");
        volumeSlider.value = volumeValue;

        AudioListener.volume = volumeValue;
    }
}
