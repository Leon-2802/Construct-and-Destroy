using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class zoomOut : MonoBehaviour
{
    [SerializeField] private float zoomSpeed = 7f;
    private float zoomTime = 3f;
    public wallEastDamage wallEast;
    public wallWestDamage wallWest;
    [SerializeField] private GameObject fightCanvas = null;
    [SerializeField] private GameObject winnerCanvas = null;
    [SerializeField] private TMP_Text winner = null;
    [SerializeField] private playerEastControl playerEastControl = null;
    [SerializeField] private playerWestInput playerWestInput = null;
    [SerializeField] private GameObject buildPhase = null;
    [SerializeField] private PauseMenuCtrl pauseMenuCtrl = null;
    [SerializeField] private AudioSource music = null;
    private bool disabled = false;
    private bool winnerScreenBool = false;
    void Update()
    {
        if(wallEast.currentHealth <= 0 || wallWest.currentHealth <= 0) {
            if(disabled == false) {
                DisableScripts();
            }
            transform.Translate(Vector3.back * zoomSpeed * Time.deltaTime);
            zoomTime -= Time.deltaTime;
            if(zoomTime <= 0f && winnerScreenBool == false) {
                winnerScreen();
            }
        }
    }

    void DisableScripts() {
        disabled = true;
        playerEastControl.enabled = false;
        playerWestInput.enabled = false;
        pauseMenuCtrl.enabled = false;
        buildPhase.SetActive(false);
    }

    void winnerScreen() {
        music.volume = 0.1f;
        winnerScreenBool = true;
        Time.timeScale = 0f;
        zoomSpeed = 0f;
        fightCanvas.SetActive(false);
        winnerCanvas.SetActive(true);
        if(wallEast.currentHealth <= 0) {
            winner.text = "Player 1 has won the Game!";
        }
        else if(wallWest.currentHealth <= 0) {
            winner.text = "Player 2 has won the Game!";
        }
    }
}
