using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buildCtrlEast : MonoBehaviour
{
    // Inputs:
    BuildEast inputCtrl;

    //Tower handling:
    //UI:
    [SerializeField] private Text towerNameEast = null;
    [SerializeField] private Text towerPrizeEast = null;
    [SerializeField] private string[] towerName = null;
    [SerializeField] private string[] towerPrize = null;
    private int switchCount = 0;

    //TowerSpawn:
    [SerializeField] private Transform towerEastSpawn = null;
    [SerializeField] private GameObject[] towerPrefabs = null;
    public Transform tower = null;
    private GameObject selectedTower = null;
    [SerializeField] private Material towerGrey = null;
    [SerializeField] private Material towerBlue = null;

    //generelle UI:
    [SerializeField] private Text moneyEast = null;
    public int moneyEastNr = 0;
    public phaseManager phaseManager = null;
    public towerManagement towerManagement = null;

    //health:
    [SerializeField] private wallEastDamage wallEast = null;

    void Awake() 
    {
        inputCtrl = new BuildEast();

        inputCtrl.build.moveUp.performed += ctx => moveUp();
        inputCtrl.build.moveDown.performed += ctx => moveDown();
        inputCtrl.build.moveLeft.performed += ctx => moveLeft();
        inputCtrl.build.moveRight.performed += ctx => moveRight();

        inputCtrl.build.switchLeft.performed += ctx => switchLeft();
        inputCtrl.build.switchRight.performed += ctx => switchRight();

        // inputCtrl.build.select.performed += ctx => selectTower();

        inputCtrl.build.plant.performed += ctx => plant();
        inputCtrl.build.cancel.performed += ctx => cancel();
    }

    private void Start() {
        moneyEastNr = phaseManager.moneyEast;
        moneyEast.text = moneyEastNr.ToString();
        switchCount = 0;
        selectedTower = Instantiate(towerPrefabs[switchCount], towerEastSpawn.position, Quaternion.identity);
        selectedTower.GetComponentInChildren<MeshRenderer>().material = towerGrey;
        tower = selectedTower.transform;
        StartCoroutine(destroyUnplanted());
    }
    public void newRound()
    {
        moneyEastNr = phaseManager.moneyEast;
        moneyEast.text = moneyEastNr.ToString();
        switchCount = 0;
        towerNameEast.text = towerName[switchCount];
        towerPrizeEast.text = towerPrize[switchCount];
        selectedTower = Instantiate(towerPrefabs[switchCount], towerEastSpawn.position, Quaternion.identity);
        selectedTower.GetComponentInChildren<MeshRenderer>().material = towerGrey;
        tower = selectedTower.transform;
        StartCoroutine(destroyUnplanted());
    }

    void moveUp() {
        if(tower != null) {
            soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerMove);
            tower.transform.Translate(Vector3.forward);
        }
    }
    void moveDown() {
        if(tower != null) {
            soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerMove);
            tower.transform.Translate(Vector3.back);
        }
    }
    void moveLeft() {
        if(tower != null) {
            soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerMove);
            tower.transform.Translate(Vector3.left);
        }
    }
    void moveRight() {
        if(tower != null) {
            soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerMove);
            tower.transform.Translate(Vector3.right);
        }
    }

    void switchLeft() 
    {
        if(switchCount <= 0) {
            soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerClick);
            switchCount = 5;
            towerNameEast.text = towerName[switchCount];
            towerPrizeEast.text = towerPrize[switchCount];
            //alten tower zerstören
            if(selectedTower != null) {
                Destroy(selectedTower);
                selectedTower = null;
                tower = null;
            }
            //neuen erstellen:
            selectedTower = Instantiate(towerPrefabs[switchCount], towerEastSpawn.position, Quaternion.identity);
            selectedTower.GetComponentInChildren<MeshRenderer>().material = towerGrey;
            tower = selectedTower.transform;
        }
        else {
            soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerClick);
            switchCount--;
            towerNameEast.text = towerName[switchCount];
            towerPrizeEast.text = towerPrize[switchCount];
            //alten tower zerstören
            if(selectedTower != null) {
            Destroy(selectedTower);
            selectedTower = null;
            tower = null;
            }
            //neuen erstellen:
            selectedTower = Instantiate(towerPrefabs[switchCount], towerEastSpawn.position, Quaternion.identity);
            selectedTower.GetComponentInChildren<MeshRenderer>().material = towerGrey;
            tower = selectedTower.transform;
        }
    }
    void switchRight() 
    {
        if(switchCount >= 5) {
            soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerClick);
            switchCount = 0;
            towerNameEast.text = towerName[switchCount];
            towerPrizeEast.text = towerPrize[switchCount];
            //alten tower zerstören
            if(selectedTower != null) {
                Destroy(selectedTower);
                selectedTower = null;
                tower = null;
            }
            //neuen erstellen:
            selectedTower = Instantiate(towerPrefabs[switchCount], towerEastSpawn.position, Quaternion.identity);
            selectedTower.GetComponentInChildren<MeshRenderer>().material = towerGrey;
            tower = selectedTower.transform;
        }
        else {
            soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerClick);
            switchCount++;
            towerNameEast.text = towerName[switchCount];
            towerPrizeEast.text = towerPrize[switchCount];
            //alten tower zerstören
            if(selectedTower != null) {
                Destroy(selectedTower);
                selectedTower = null;
                tower = null;
            }
            //neuen erstellen:
            selectedTower = Instantiate(towerPrefabs[switchCount], towerEastSpawn.position, Quaternion.identity);
            selectedTower.GetComponentInChildren<MeshRenderer>().material = towerGrey;
            tower = selectedTower.transform;
        }
    }
    void plant() 
    {
        if(tower.transform.position.x == 7f && tower.transform.position.z == 0f) {
            if(switchCount == 1) {
                switchCount = 1;
            } else {
                return;
            }
        }
        else if(tower.transform.position.x <= 0 || tower.transform.position.x >= 10 || tower.transform.position.z >= 6 || tower.transform.position.z <= -5) {
            if(switchCount == 1) {
                switchCount = 1;
            } else {
                return;
            }
        }
        switch (switchCount)
        {
            case 0:
                if(moneyEastNr >= 15) {
                    soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerPlant);
                    tower = null;
                    towerManagement.targetsWest.Add(selectedTower.transform);
                    phaseManager.towerEast.Add(selectedTower);
                    moneyEastNr -= 15;
                    moneyEast.text = moneyEastNr.ToString();
                    selectedTower.GetComponentInChildren<MeshRenderer>().material = towerBlue;
                    selectedTower.GetComponent<shotTowerEast>().towerManagement = towerManagement;
                    selectedTower.GetComponent<towerDamage>().towerManagement = towerManagement;
                    selectedTower.GetComponent<towerDamage>().phaseManager = phaseManager;
                    selectedTower = null;
                }
                break;
            case 1:
                if(moneyEastNr >= 40 && wallEast.currentHealth <= 250) {
                    soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.healing);
                    moneyEastNr -= 40;
                    moneyEast.text = moneyEastNr.ToString();
                    wallEast.heal(50);
                    cancel();
                }
                break;
            case 2:
                if(moneyEastNr >= 30) {
                    soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerPlant);
                    tower = null;
                    towerManagement.targetsWest.Add(selectedTower.transform);
                    phaseManager.moneyTowerEast.Add(selectedTower);
                    moneyEastNr -= 30;
                    moneyEast.text = moneyEastNr.ToString();
                    selectedTower.GetComponentInChildren<MeshRenderer>().material = towerBlue;
                    selectedTower.GetComponent<towerDamage>().towerManagement = towerManagement;
                    selectedTower.GetComponent<towerDamage>().phaseManager = phaseManager;
                    selectedTower = null;
                }
                break;
            case 3: 
                if(moneyEastNr >= 35) {
                    soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerPlant);
                    tower = null;
                    towerManagement.targetsWest.Add(selectedTower.transform);
                    phaseManager.iceTowerEast.Add(selectedTower);
                    selectedTower.GetComponent<MeshRenderer>().material = towerBlue;
                    selectedTower.GetComponent<iceTowerEast>().towerManagement = towerManagement;
                    selectedTower.GetComponent<towerDamage>().towerManagement = towerManagement;
                    selectedTower.GetComponent<towerDamage>().phaseManager = phaseManager;
                    moneyEastNr -= 35;
                    moneyEast.text = moneyEastNr.ToString();
                    selectedTower = null;
                }
                break;
            case 4:
                if(moneyEastNr >= 30) {
                    soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerPlant);
                    tower = null;
                    towerManagement.targetsWest.Add(selectedTower.transform);
                    phaseManager.rocketTowerEast.Add(selectedTower);
                    selectedTower.GetComponent<MeshRenderer>().material = towerBlue;
                    selectedTower.GetComponent<rocketTowerEast>().towerManagement = towerManagement;
                    selectedTower.GetComponent<towerDamage>().towerManagement = towerManagement;
                    selectedTower.GetComponent<towerDamage>().phaseManager = phaseManager;
                    moneyEastNr -= 30;
                    moneyEast.text = moneyEastNr.ToString();
                    selectedTower = null;
                }
                break;
            case 5:
                if(moneyEastNr >= 10) {
                    soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerPlant);
                    tower = null;
                    selectedTower.GetComponent<MeshRenderer>().material = towerBlue;
                    selectedTower.GetComponent<towerDamage>().towerManagement = towerManagement;
                    selectedTower.GetComponent<towerDamage>().phaseManager = phaseManager;
                    moneyEastNr -= 10;
                    moneyEast.text = moneyEastNr.ToString();
                    selectedTower = null;
                }
                break;
        }
    }
    void cancel()
    {  
        tower = null;
        // towerManagement.targetsWest.Remove(selectedTower.transform);
        // phaseManager.towerEast.Remove(selectedTower);
        selectedTower.transform.position += new Vector3(0f, 0.24f, 0f);
        StartCoroutine(destroyOnCancel());
    }
    private IEnumerator destroyOnCancel() {
        yield return new WaitForSeconds(0.1f);
        soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerCancel);
        Destroy(selectedTower);
        selectedTower = null;
    }
    
    private IEnumerator destroyUnplanted() {
        yield return new WaitForSeconds(24.6f);
        if(selectedTower != null) {
            selectedTower.transform.position += new Vector3(0f, 0.24f, 0f);
            tower = null;
            towerManagement.targetsWest.Remove(selectedTower.transform);
            phaseManager.towerEast.Remove(selectedTower);
            yield return new WaitForSeconds(0.1f);
            Destroy(selectedTower);
            selectedTower = null;
            phaseManager.moneyEast = moneyEastNr;
            this.enabled = false;
        } else {
            phaseManager.moneyEast = moneyEastNr;
            this.enabled = false;
        }
    }

    void OnEnable() {
        inputCtrl.build.Enable();
    }
    private void OnDisable() {
        inputCtrl.build.Disable();
    }


}
