using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phaseManager : MonoBehaviour
{
    public bool fightPhase = false;
    public bool buildPhase = true;
    public towerManagement towerManager;

    //materials:
    [SerializeField] private Material red = null;
    [SerializeField] private Material blue = null;

    //An/Aus:
    [SerializeField] private GameObject[] fightUI = null;
    [SerializeField] private Canvas buildUI = null;
    [SerializeField] private GameObject playerWest = null;
    public List<GameObject> towerWest = new List<GameObject>();
    public List<GameObject> moneyTowerWest = new List<GameObject>();
    public List<GameObject> rocketTowerWest = new List<GameObject>();
    public List<GameObject> iceTowerWest = new List<GameObject>();
    [SerializeField] private GameObject playerEast = null;
    public List<GameObject> towerEast = new List<GameObject>();
    public List<GameObject> moneyTowerEast = new List<GameObject>();
    public List<GameObject> rocketTowerEast = new List<GameObject>();
    public List<GameObject> iceTowerEast = new List<GameObject>();
    [SerializeField] private GameObject buildControls = null;
    // private int roundCounter = 0;
    public timerBuild timerBuild;
    public timer timerFight;
    public int moneyWest = 20;
    public int moneyEast = 20; 

    private void Start() {
        fightPhase = false;
        buildPhase = true;
    } 

    public void changePhase()
    {
        if(buildPhase == true && fightPhase == false) {
            //UI:
            foreach(GameObject Image in fightUI) {
                Image.SetActive(false);
            }
            buildUI.gameObject.SetActive(true);
            timerBuild.setStartTime();
            //players:
            moneyWest = playerWest.GetComponent<playerWestInput>().moneyWest;
            playerWest.gameObject.SetActive(false);
            moneyEast = playerEast.GetComponent<playerEastControl>().moneyEast;
            playerEast.gameObject.SetActive(false);
            //buildControls:
            buildControls.GetComponent<buildCtrlEast>().enabled = true;
            buildControls.GetComponent<buildCtrlWest>().enabled = true;
            buildControls.GetComponent<buildCtrlEast>().newRound();
            buildControls.GetComponent<buildCtrlWest>().newRound();
            //Skripte der Tower abschalten:
            foreach(GameObject tower in towerEast) {
                tower.GetComponent<shotTowerEast>().StopAllCoroutines();
                tower.GetComponent<shotTowerEast>().target = null;
                tower.GetComponent<shotTowerEast>().enabled = false;
                tower.GetComponent<towerDamage>().enabled = false;
            }
            foreach(GameObject tower in moneyTowerEast) {
                tower.GetComponent<moneyTower>().StopAllCoroutines();
                tower.GetComponent<moneyTower>().enabled = false;
                tower.GetComponent<towerDamage>().enabled = false;
            }
            foreach(GameObject tower in rocketTowerEast) {
                tower.GetComponent<rocketTowerEast>().StopAllCoroutines();
                tower.GetComponent<rocketTowerEast>().enabled = false;
                tower.GetComponent<towerDamage>().enabled = false;
            }
            foreach(GameObject tower in iceTowerEast) {
                tower.GetComponent<iceTowerEast>().StopAllCoroutines();
                tower.GetComponent<iceTowerEast>().enabled = false;
                tower.GetComponent<towerDamage>().enabled = false;
            }

            foreach(GameObject tower in towerWest) {
                tower.GetComponent<shotTowerWest>().StopAllCoroutines();
                tower.GetComponent<shotTowerWest>().target = null;
                tower.GetComponent<shotTowerWest>().enabled = false;
                tower.GetComponent<towerDamage>().enabled = false;
            }
            foreach(GameObject tower in moneyTowerWest) {
                tower.GetComponent<moneyTower>().StopAllCoroutines();
                tower.GetComponent<moneyTower>().enabled = false;
                tower.GetComponent<towerDamage>().enabled = false;
            }
            foreach(GameObject tower in rocketTowerWest) {
                tower.GetComponent<rocketTowerWest>().StopAllCoroutines();
                tower.GetComponent<rocketTowerWest>().enabled = false;
                tower.GetComponent<towerDamage>().enabled = false;
            }
            foreach(GameObject tower in iceTowerWest) {
                tower.GetComponent<iceTowerWest>().StopAllCoroutines();
                tower.GetComponent<iceTowerWest>().enabled = false;
                tower.GetComponent<towerDamage>().enabled = false;
            }
        }
        else if(buildPhase == false && fightPhase ==true) {
            //UI
            buildUI.gameObject.SetActive(false);
            foreach(GameObject Image in fightUI) {
                Image.SetActive(true);
            }
            timerFight.setStartTime();
            //playerWest
            playerWest.gameObject.SetActive(true);
            playerWest.GetComponent<playerWestInput>().moneyWest = moneyWest;
            playerWest.GetComponent<playerWestInput>().resetAbillities();
            playerWest.GetComponent<hitProcessingWest>().startAgain();
            playerWest.transform.position = new Vector3(-9f, 0.75f, 0f);
            playerWest.GetComponent<MeshRenderer>().material = red;
            playerWest.GetComponent<Rigidbody>().rotation = Quaternion.identity;
            //playerEast
            playerEast.gameObject.SetActive(true);
            playerEast.GetComponent<playerEastControl>().moneyEast = moneyEast;
            playerEast.GetComponent<playerEastControl>().resetAbillities();
            playerEast.GetComponent<hitProcessingEast>().startAgain();
            playerEast.transform.position = new Vector3(7f, 0.75f, 0f);
            playerEast.GetComponent<MeshRenderer>().material = blue;
            playerEast.GetComponent<Rigidbody>().rotation = Quaternion.identity; 
            //activate TowerScript:
            foreach(GameObject tower in towerEast) {
                tower.GetComponent<shotTowerEast>().enabled = true;
                tower.GetComponent<towerDamage>().enabled = true;
            }
            foreach(GameObject tower in moneyTowerEast) {
                tower.GetComponent<moneyTower>().enabled = true;
                tower.GetComponent<moneyTower>().callFirstCoroutine();
                tower.GetComponent<towerDamage>().enabled = true;
            }
            foreach(GameObject tower in rocketTowerEast) {
                tower.GetComponent<rocketTowerEast>().enabled = true;
                tower.GetComponent<rocketTowerEast>().callFirstShot();
                tower.GetComponent<towerDamage>().enabled = true;
            }
            foreach(GameObject tower in iceTowerEast) {
                tower.GetComponent<iceTowerEast>().enabled = true;
                tower.GetComponent<iceTowerEast>().callFirstShot();
                tower.GetComponent<towerDamage>().enabled = true;
            }

            foreach(GameObject tower in towerWest) {
                tower.GetComponent<shotTowerWest>().enabled = true;
                tower.GetComponent<towerDamage>().enabled = true;
            }
            foreach(GameObject tower in moneyTowerWest) {
                tower.GetComponent<moneyTower>().enabled = true;
                tower.GetComponent<moneyTower>().callFirstCoroutine();
                tower.GetComponent<towerDamage>().enabled = true;
            }
            foreach(GameObject tower in rocketTowerWest) {
                tower.GetComponent<rocketTowerWest>().enabled = true;
                tower.GetComponent<rocketTowerWest>().callFirstShot();
                tower.GetComponent<towerDamage>().enabled = true;
            }
            foreach(GameObject tower in iceTowerWest) {
                tower.GetComponent<iceTowerWest>().enabled = true;
                tower.GetComponent<iceTowerWest>().callFirstShot();
                tower.GetComponent<towerDamage>().enabled = true;
            }
        }
    }
}
