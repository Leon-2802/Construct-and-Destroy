using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public AudioSource Audio;
    public AudioClip shot;
    public AudioClip coin;
    public AudioClip energyExplosion;
    public AudioClip error;
    public AudioClip healing;
    public AudioClip iceHit;
    public AudioClip iceShot;
    public AudioClip playerHit;
    public AudioClip towerCancel;
    public AudioClip towerClick;
    public AudioClip towerExplosion;
    public AudioClip towerMove;
    public AudioClip towerPlant;
    public static soundManager sManagerInstance; //gibt immer nur eine einzige Instanz, daher die Abfrage in Awake
    private void Awake() 
    {
        if(sManagerInstance != null && sManagerInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        sManagerInstance = this;
        DontDestroyOnLoad(this);
    }
}
