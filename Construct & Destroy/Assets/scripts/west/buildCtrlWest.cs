using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buildCtrlWest : MonoBehaviour
{
    // Inputs:
    BuildWest inputCtrl;

    //Tower handling:
    Vector3 origin;
    public LayerMask towerLayer;
    public rangeSpheresWest sphereScr;
    //UI:
    [SerializeField] private Text towerNameWest = null;
    [SerializeField] private Text towerPrizeWest = null;
    [SerializeField] private string[] towerName = null;
    [SerializeField] private string[] towerPrize = null;
    [SerializeField] private float[] sphereScale = null;
    private int switchCount = 0;

    //TowerSpawn:
    [SerializeField] private Transform towerWestSpawn = null;
    [SerializeField] private GameObject[] towerPrefabs = null;
    public Transform tower = null;
    private GameObject selectedTower = null;
    [SerializeField] private Material towerGrey = null;
    [SerializeField] private Material towerRed = null;

    //generelle UI:
    [SerializeField] private Text moneyWest = null;
    public int moneyWestNr = 0;
    public phaseManager phaseManager = null;
    public towerManagement towerManagement = null;

    //health:
    [SerializeField] private wallWestDamage wallWest = null;

    void Awake() 
    {
        inputCtrl = new BuildWest();

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
        moneyWestNr = phaseManager.moneyWest;
        moneyWest.text = moneyWestNr.ToString();
        switchCount = 0;
        selectedTower = Instantiate(towerPrefabs[switchCount], towerWestSpawn.position, Quaternion.identity);
        selectedTower.GetComponentInChildren<MeshRenderer>().material = towerGrey;
        tower = selectedTower.transform;
        sphereScr.spawnSphere(sphereScale[switchCount], tower);
        StartCoroutine(destroyUnplanted());
    }
    public void newRound()
    {
        moneyWestNr = phaseManager.moneyWest;
        moneyWest.text = moneyWestNr.ToString();
        switchCount = 0;
        towerNameWest.text = towerName[switchCount];
        towerPrizeWest.text = towerPrize[switchCount];
        selectedTower = Instantiate(towerPrefabs[switchCount], towerWestSpawn.position, Quaternion.identity);
        selectedTower.GetComponentInChildren<MeshRenderer>().material = towerGrey;
        tower = selectedTower.transform;
        sphereScr.spawnSphere(sphereScale[switchCount], tower);
        StartCoroutine(destroyUnplanted());
    }

    void moveUp() {
        if(tower != null) {
            if(tower.transform.position.z >= 5 || switchCount == 1) {
                return;
            }
            else if(tower != null) {
                origin = tower.position + Vector3.forward;
                bool blocked = Physics.Linecast(tower.position, origin, towerLayer);
                if(blocked == true) {
                    return;
                }
                soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerMove);
                tower.transform.Translate(Vector3.forward);
            }
        }
    }
    void moveDown() {
        if(tower != null) {
            if(tower.transform.position.z <= -4 || switchCount == 1) {
                return;
            }
            else if(tower != null) {
                origin = tower.position + Vector3.back;
                bool blocked = Physics.Linecast(tower.position, origin, towerLayer);
                if(blocked == true) {
                    return;
                }
                soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerMove);
                tower.transform.Translate(Vector3.back);
            }
        }
    }
    void moveLeft() {
        if(tower != null) {
            if(tower.transform.position.x <= -10 || switchCount == 1) {
                return;
            }
            else if(tower != null) {
                origin = tower.position + Vector3.left;
                bool blocked = Physics.Linecast(tower.position, origin, towerLayer);
                if(blocked == true) {
                    return;
                }
                soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerMove);
                tower.transform.Translate(Vector3.left);
            }
        }
    }
    void moveRight() {
        if(tower != null) {
            if(tower.transform.position.x >= -1 || switchCount == 1) {
                return;
            }
            else if(tower != null) {
                origin = tower.position + Vector3.right;
                bool blocked = Physics.Linecast(tower.position, origin, towerLayer);
                if(blocked == true) {
                    return;
                }
                soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerMove);
                tower.transform.Translate(Vector3.right);
            }
        }
    }

    void switchLeft() 
    {
        if(switchCount <= 0) {
            soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerClick);
            switchCount = 5;
            towerNameWest.text = towerName[switchCount];
            towerPrizeWest.text = towerPrize[switchCount];
            //alten tower zerstören
            if(selectedTower != null) {
                Destroy(selectedTower);
                selectedTower = null;
                tower = null;
            }
            //neuen erstellen:
            selectedTower = Instantiate(towerPrefabs[switchCount], towerWestSpawn.position, Quaternion.identity);
            selectedTower.GetComponentInChildren<MeshRenderer>().material = towerGrey;
            tower = selectedTower.transform;
            if(switchCount == 0 || switchCount == 3 || switchCount == 4) {
                tower = selectedTower.transform;
                sphereScr.spawnSphere(sphereScale[switchCount], tower);
            }
        }
        else {
            soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerClick);
            switchCount--;
            towerNameWest.text = towerName[switchCount];
            towerPrizeWest.text = towerPrize[switchCount];
            if(selectedTower != null) {
                Destroy(selectedTower);
                selectedTower = null;
                tower = null;
            }
            selectedTower = Instantiate(towerPrefabs[switchCount], towerWestSpawn.position, Quaternion.identity);
            selectedTower.GetComponentInChildren<MeshRenderer>().material = towerGrey;
            tower = selectedTower.transform;
            if(switchCount == 0 || switchCount == 3 || switchCount == 4) {
                sphereScr.spawnSphere(sphereScale[switchCount], tower);
            }
        }
    }
    void switchRight() 
    {
        if(switchCount >= 5) {
            soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerClick);
            switchCount = 0;
            towerNameWest.text = towerName[switchCount];
            towerPrizeWest.text = towerPrize[switchCount];
            //alten tower zerstören
            if(selectedTower != null) {
                Destroy(selectedTower);
                selectedTower = null;
                tower = null;
            }
            //neuen erstellen:
            selectedTower = Instantiate(towerPrefabs[switchCount], towerWestSpawn.position, Quaternion.identity);
            selectedTower.GetComponentInChildren<MeshRenderer>().material = towerGrey;
            tower = selectedTower.transform;
            if(switchCount == 0 || switchCount == 3 || switchCount == 4) {
                sphereScr.spawnSphere(sphereScale[switchCount], tower);
            }
        }
        else {
            soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerClick);
            switchCount++;
            towerNameWest.text = towerName[switchCount];
            towerPrizeWest.text = towerPrize[switchCount];
            //alten tower zerstören
            if(selectedTower != null) {
                Destroy(selectedTower);
                selectedTower = null;
                tower = null;
            }
            //neuen erstellen:
            selectedTower = Instantiate(towerPrefabs[switchCount], towerWestSpawn.position, Quaternion.identity);
            selectedTower.GetComponentInChildren<MeshRenderer>().material = towerGrey;
            tower = selectedTower.transform;
            if(switchCount == 0 || switchCount == 3 || switchCount == 4) {
                sphereScr.spawnSphere(sphereScale[switchCount], tower);
            }
        }
    }
    void plant() 
    {
        if(tower.transform.position.x == -9f && tower.transform.position.z == 0f) {
            if(switchCount == 1) {
                switchCount = 1;
            } else {
                return;
            }
        }
        else if(tower.transform.position.x >= -1 || tower.transform.position.x <= -11 || tower.transform.position.z >= 6 || tower.transform.position.z <= -5) {
            if(switchCount == 1) {
                switchCount = 1;
            } else {
                return;
            }
        }
        switch (switchCount)
        {
            case 0:
                if(moneyWestNr >= 15) {
                    soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerPlant);
                    tower = null;
                    towerManagement.targetsEast.Add(selectedTower.transform);
                    phaseManager.towerWest.Add(selectedTower);
                    moneyWestNr -= 15;
                    moneyWest.text = moneyWestNr.ToString();
                    selectedTower.GetComponentInChildren<MeshRenderer>().material = towerRed;
                    selectedTower.GetComponent<shotTowerWest>().towerManagement = towerManagement;
                    selectedTower.GetComponent<towerDamage>().towerManagement = towerManagement;
                    selectedTower.GetComponent<towerDamage>().phaseManager = phaseManager;
                    selectedTower = null;
                    sphereScr.destroySphere();
                }
                break;
            case 1:
                if(moneyWestNr >= 40) {
                    if(wallWest.currentHealth <= 250) {
                        soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.healing);
                        moneyWestNr -= 40;
                        moneyWest.text = moneyWestNr.ToString();
                        wallWest.heal(50);
                        cancel();
                    }
                }
                break;
            case 2:
                if(moneyWestNr >= 30) {
                    soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerPlant);
                    tower = null;
                    towerManagement.targetsEast.Add(selectedTower.transform);
                    phaseManager.moneyTowerWest.Add(selectedTower);
                    moneyWestNr -= 30;
                    moneyWest.text = moneyWestNr.ToString();
                    selectedTower.GetComponentInChildren<MeshRenderer>().material = towerRed;
                    selectedTower.GetComponent<towerDamage>().towerManagement = towerManagement;
                    selectedTower.GetComponent<towerDamage>().phaseManager = phaseManager;
                    selectedTower = null;
                }
                break;
            case 3:
                if(moneyWestNr >= 35) {
                    soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerPlant);
                    tower = null;
                    towerManagement.targetsEast.Add(selectedTower.transform);
                    phaseManager.iceTowerWest.Add(selectedTower);
                    moneyWestNr -= 35;
                    moneyWest.text = moneyWestNr.ToString();
                    selectedTower.GetComponentInChildren<MeshRenderer>().material = towerRed;
                    selectedTower.GetComponent<iceTowerWest>().towerManagement = towerManagement;
                    selectedTower.GetComponent<towerDamage>().towerManagement = towerManagement;
                    selectedTower.GetComponent<towerDamage>().phaseManager = phaseManager;
                    selectedTower = null;
                    sphereScr.destroySphere();
                }
                break;
            case 4:
                if(moneyWestNr >= 30) {
                    soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerPlant);
                    tower = null;
                    towerManagement.targetsEast.Add(selectedTower.transform);
                    phaseManager.rocketTowerWest.Add(selectedTower);
                    selectedTower.GetComponent<MeshRenderer>().material = towerRed;
                    selectedTower.GetComponent<rocketTowerWest>().towerManagement = towerManagement;
                    selectedTower.GetComponent<towerDamage>().towerManagement = towerManagement;
                    selectedTower.GetComponent<towerDamage>().phaseManager = phaseManager;
                    moneyWestNr -= 30;
                    moneyWest.text = moneyWestNr.ToString();
                    selectedTower = null;
                    sphereScr.destroySphere();
                }
                break;
            case 5:
                if(moneyWestNr >= 5) {
                    soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.towerPlant);
                    tower = null;
                    selectedTower.GetComponent<MeshRenderer>().material = towerRed;
                    selectedTower.GetComponent<towerDamage>().towerManagement = towerManagement;
                    selectedTower.GetComponent<towerDamage>().phaseManager = phaseManager;
                    moneyWestNr -= 5;
                    moneyWest.text = moneyWestNr.ToString();
                    selectedTower = null;
                }
                break;
        }
    }
    void cancel()
    {  
        tower = null;
        towerManagement.targetsEast.Remove(selectedTower.transform);
        phaseManager.towerWest.Remove(selectedTower);
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
            towerManagement.targetsEast.Remove(selectedTower.transform);
            phaseManager.towerWest.Remove(selectedTower);
            yield return new WaitForSeconds(0.1f);
            Destroy(selectedTower);
            selectedTower = null;
            phaseManager.moneyWest = moneyWestNr;
            this.enabled = false; 
        }
        else {
            phaseManager.moneyWest = moneyWestNr;
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
