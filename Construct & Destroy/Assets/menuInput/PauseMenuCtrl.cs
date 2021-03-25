using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using TMPro;

public class PauseMenuCtrl : MonoBehaviour
{
    PauseMenu pauseMenu;
    [SerializeField] private GameObject canvasFight = null;
    [SerializeField] private GameObject canvasBuild = null;
    [SerializeField] private GameObject canvasPause = null;
    [SerializeField] private AudioSource musicSrc = null;

    //scirpts:
    [SerializeField] private GameObject buildScr = null;
    [SerializeField] private GameObject plyWest = null;
    [SerializeField] private GameObject plyEast = null;

    [SerializeField] private TMP_Text[] pauseTxts = null;
    private int moveCounter = 0;

    [SerializeField] private phaseManager phaseManager = null;
    private bool paused = false;

    private void Awake() {
        pauseMenu = new PauseMenu();

        pauseMenu.input.call.performed += ctx => startStop();

        pauseMenu.input.moveDown.performed += ctx => moveDown();
        pauseMenu.input.moveUp.performed += ctx => moveUp();
        pauseMenu.input.select.performed += ctx => select(); 
    }

    void startStop() {
        if(paused == false) {
            Time.timeScale = 0f;
            musicSrc.volume = 0.1f;
            if(phaseManager.buildPhase == true && phaseManager.fightPhase == false) {
                canvasBuild.SetActive(false);
                buildScr.SetActive(false);
            }
            else {
                canvasFight.SetActive(false);
                plyEast.SetActive(false);
                plyWest.SetActive(false);
            }
            canvasPause.SetActive(true);
            paused = true;
            return;
        }
        else if(paused == true) {
            Time.timeScale = 1f;
            musicSrc.volume = 0.3f;
            canvasPause.SetActive(false);
            if(phaseManager.buildPhase == true && phaseManager.fightPhase == false) {
                canvasBuild.SetActive(true);
                buildScr.SetActive(true);
            }
            else {
                canvasFight.SetActive(true);
                plyEast.SetActive(true);
                plyWest.SetActive(true);
            }
            paused = false;
        }
    }

    void moveDown() {
        if(moveCounter <= 1 && paused == true) {
            moveCounter++;
            pauseTxts[moveCounter - 1].fontStyle = FontStyles.Bold;
            pauseTxts[moveCounter].fontStyle = FontStyles.Underline;
        }
    }
    void moveUp() {
        if(moveCounter >= 1 && paused == true) {
            moveCounter--;
            pauseTxts[moveCounter + 1].fontStyle = FontStyles.Normal;
            pauseTxts[moveCounter].fontStyle = FontStyles.Underline;
        }
    }
    void select() {
        if(paused == true) {
            switch(moveCounter) {
                case 0:
                    break;
                case 1:
                    if(paused == true) {
                        startStop();
                    }
                    break;
                case 2:
                    if(paused == true) {
                        Time.timeScale = 1f;
                        SceneManager.LoadSceneAsync("startMenu");
                    }
                    break;             
            }
        }
    }

    private void OnEnable() {
        pauseMenu.Enable();
    }

    private void OnDisable() {
        pauseMenu.Disable();
    }
}
