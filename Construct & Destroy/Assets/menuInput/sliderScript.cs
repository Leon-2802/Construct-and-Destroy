using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class sliderScript : MonoBehaviour
{
    public AudioMixer audioMixer;
    public AudioMixer sfxMix;

    public void setVolume(float volume)
    {
        Debug.Log(volume);
        audioMixer.SetFloat("volume", Mathf.Log10(volume) * 20);
    }

    public void setVolumeSFX (float volume)
    {
        sfxMix.SetFloat("sfxVolume", Mathf.Log10(volume) * 20);
    }
}
