using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class sliderScript : MonoBehaviour
{
    [SerializeField] private AudioSource sfxSrc = null;
    public AudioMixer audioMixer;
    public AudioMixer sfxMix;

    public void setVolume(float volume)
    {
        audioMixer.SetFloat("volume", Mathf.Log10(volume) * 20);
    }

    public void setVolumeSFX (float volume)
    {
        sfxMix.SetFloat("sfxVolume", Mathf.Log10(volume) * 20);
        sfxSrc.Play();
    }
}
