using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AudioSlider : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider = null;



    [SerializeField] private Text volumeTextUI = null;
    private void Start()
    {
        LoadValues();
    }

    public void VolumeSlider(float volume)
    {
        volumeTextUI.text = volume.ToString("0.0");

    }
   
    
    public void saveVolumeButton()
    {
        float volumeValue = volumeSlider.value;
        PlayerPrefs.SetFloat("VolumeValue", volumeValue);
        LoadValues();
    }

    public void LoadValues()
    {
        float volumeValue = PlayerPrefs.GetFloat("VolumeValue");
        volumeSlider.value = volumeValue;
        // Because I am using Audio Listener component, any volume which
        // we might add will be modified by this, so if we have multiple audio's
        // and user change the volume it will affect all existing volumes.
        AudioListener.volume = volumeValue;

       
        /*Debug.Log("Audio Settings has been Saved");*/
    }
}
