using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MenuOptionSetting : MonoBehaviour
{
    public AudioMixer audioMixerMusica;
    public AudioMixer audioMixerEffects;

    public void SetVolume (float volume)
    {
        audioMixerMusica.SetFloat("volume", volume);
    }

    public void SetVolumeEffects(float volumeE)
    {
        audioMixerEffects.SetFloat("volumeE", volumeE);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullScreen(bool isfullScreen)
    {
        Screen.fullScreen = isfullScreen;
    }
}
