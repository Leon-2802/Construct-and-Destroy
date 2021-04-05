using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class endOfGame : MonoBehaviour
{
    MenuCtrl menuCtrl;

    private void Awake() {
        menuCtrl = new MenuCtrl();

        menuCtrl.input.confirm.performed += ctx => playAgain();
        menuCtrl.input.back.performed += ctx => mainMenu();
    }

    void playAgain() {
        Time.timeScale = 1f;
        SceneManager.LoadScene("battle");
    }

    void mainMenu() {
        Time.timeScale = 1f;
        SceneManager.LoadScene("startMenu");
    }

    private void OnEnable() {
        menuCtrl.Enable();
    }

    private void OnDisable() {
        menuCtrl.Disable();
    }
}
