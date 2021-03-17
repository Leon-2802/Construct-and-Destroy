using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playlist : MonoBehaviour
{
    public AudioClip[] clips;
    [SerializeField] private AudioSource audioSource = null;
    void Start()
    {
        audioSource.loop = false;
    }

    private AudioClip getRandomClip()
    {
        return clips[Random.Range(0, clips.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        if(!audioSource.isPlaying)
        {
            audioSource.clip = getRandomClip();
            audioSource.Play();
        }
    }
}
