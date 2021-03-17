using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class menuController : MonoBehaviour
{
    MenuCtrl inputCtrl;

    public GameObject startMenu, mainMenu, optionsMenu, aboutMenu;
    public GameObject mainMenuFirstBtn, optionsMenuFirstBtn, aboutMenuFirstBtn, optionsBackBtn;

    [SerializeField] private GameObject[] mainMenuBtns = null;

    private int positionCount = 0;

    private void Awake() {
        inputCtrl = new MenuCtrl();

        inputCtrl.input.start.performed += ctx => enterMenu();

        inputCtrl.input.down.performed += ctx => moveDown();

        inputCtrl.input.up.performed += ctx => moveUp();

        inputCtrl.input.confirm.performed += ctx => select();
    }

    void enterMenu() 
    {
        if(!mainMenu.activeInHierarchy) {
            startMenu.SetActive(false);
            mainMenu.SetActive(true);
            EventSystem.current.SetSelectedGameObject(mainMenuFirstBtn);
        }
    }

    void moveDown()
    {
        if(mainMenu.activeInHierarchy && positionCount >= 0 && positionCount <= 2) {
            positionCount++;
            EventSystem.current.SetSelectedGameObject(mainMenuBtns[positionCount]);
        }
    }
    void moveUp() 
    {
        if(mainMenu.activeInHierarchy && positionCount <= 3 && positionCount >= 1) {
            positionCount--;
            EventSystem.current.SetSelectedGameObject(mainMenuBtns[positionCount]);
        }
    }

    void select() {
        if(mainMenu.activeInHierarchy) {
            switch(positionCount) {
                case 0:
                    SceneManager.LoadScene("battle");
                    break;
                case 1:
                    mainMenu.SetActive(false);
                    optionsMenu.SetActive(true);
                    EventSystem.current.SetSelectedGameObject(optionsMenuFirstBtn);
                    break;
                case 2:
                    mainMenu.SetActive(false);
                    aboutMenu.SetActive(true);
                    EventSystem.current.SetSelectedGameObject(aboutMenuFirstBtn);
                    break;
                case 3:
                    Application.Quit();
                    break;
            }
        }
    }
    
    private void OnEnable() {
        inputCtrl.Enable();
    }
    private void OnDisable() {
        inputCtrl.Disable();
    }
}
