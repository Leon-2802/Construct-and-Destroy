using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hitProcessingEast : MonoBehaviour
{
    public Rigidbody rb;
    public healthbar healthbarScr;
    [SerializeField] private int maxHealth = 100;
    private int currentHealth;
    [SerializeField] private MeshRenderer cubeRenderer = null;
    [SerializeField] private Material[] colors = null;
    private bool ice = false;
    [SerializeField] private GameObject explosion = null;
    public respawnManager respawnManager;
    public bool dead = false;
    public playerEastControl playerEastControl;
    // [SerializeField] private phaseManager phaseManager = null;

    //geld:
    [SerializeField] private GameObject coin = null;
    [SerializeField] private Transform[] coinSpawns = null;


    private void Start() {
        healthbarScr.SetMaxHealth(maxHealth);
        currentHealth = maxHealth;
    }
    public void startAgain() {
        if(dead == true) {
            healthbarScr.SetMaxHealth(maxHealth);
            currentHealth = maxHealth;
            ice = false;
            cubeRenderer.material = colors[0];
            playerEastControl.speed = 15f;
            dead = false;
        }
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("bulletWest")) {
            Hurt(2);
        }
        else if(other.CompareTag("iceWest")) {
            soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.iceHit);
            playerEastControl.speed = 2f;
            cubeRenderer.material = colors[2];
            ice = true;
            StartCoroutine(normalSpeed());
        }
    }
    private IEnumerator normalSpeed() {
        yield return new WaitForSeconds(5f);
        playerEastControl.speed = 15f;
        ice = false;
        cubeRenderer.material = colors[0];
    }
    
    public void Hurt(int damage) 
    {
        soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.playerHit);
        cubeRenderer.material = colors[1];
        StartCoroutine(backToNormal());
        currentHealth -= damage;
        healthbarScr.SetHealth(currentHealth);
        if(currentHealth <= 0) {
            ded();
        }
    }
    private void ded() {
        Instantiate(explosion, transform.position, transform.rotation);
        for(int i = 0; i < 3; i++) {
            Instantiate(coin, coinSpawns[i].position, coinSpawns[i].rotation);
        }
        StopAllCoroutines();
        dead = true;
        respawnManager.callRespawnEast();
        this.gameObject.SetActive(false);
    }
    private IEnumerator backToNormal()
    {
        yield return new WaitForSeconds(0.3f);
        if(ice == false) {
            cubeRenderer.material = colors[0];
        } else {
            cubeRenderer.material = colors[2];
        }
    }
}
