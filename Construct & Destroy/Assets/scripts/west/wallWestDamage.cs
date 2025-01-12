﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class wallWestDamage : MonoBehaviour
{
    public healthbar health;
    [SerializeField] private int wallHealth = 500;
    public int currentHealth;
    [SerializeField] private MeshRenderer mesh = null;
    [SerializeField] private Material[] colors = null;
    // [SerializeField] private GameObject fightCanvas = null;
    // [SerializeField] private GameObject winnerCanvas = null;
    // [SerializeField] private TMP_Text winner = null;
    void Start()
    {
        health.SetMaxHealth(wallHealth);
        currentHealth = wallHealth;
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("bulletEast")) {
            damage(1);
        }
        else if(other.CompareTag("rocketEastPly")) {
            damage(20);
        }
        else if(other.CompareTag("laserEast")) {
            damage(5);
        }
    }

    private void damage(int damage) {
        currentHealth -= damage;
        health.SetHealth(currentHealth);
        mesh.material = colors[1];
        if(currentHealth <= 0) {
            return;
        } else {
            StartCoroutine(normal());
        }
    }
    public void heal(int healthIncrease) {
        currentHealth += healthIncrease;
        health.SetHealth(currentHealth);
    }

    private IEnumerator normal() {
        yield return new WaitForSeconds(0.3f);
        mesh.material = colors[0];
    }

    // private IEnumerator reload() {

    //     yield return new WaitForSeconds(0.5f);
    //     Time.timeScale = 0f;
    //     fightCanvas.SetActive(false);
    //     winnerCanvas.SetActive(true);
    //     winner.text = "Player 2 has won the Game!";

    //     yield return new WaitForSeconds(3f);
    //     SceneManager.LoadScene("battle");
    // }
}

    
