using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerDamage : MonoBehaviour
{
    public healthbar healthScr;
    [SerializeField] private int maxHealth = 20;
    private int currentHealth = 0;
    private bool dead = false;
    public towerManagement towerManagement;
    public phaseManager phaseManager;
    [SerializeField] private GameObject explosion = null;
    [SerializeField] private string bulletTag = null;
    [SerializeField] private string playerSide = null;
    [SerializeField] private string towerType = null;
    [SerializeField] private MeshRenderer[] meshes = null;
    [SerializeField] private Material[] colors = null;

    //Geld:
    [SerializeField] private GameObject coinWest = null;
    [SerializeField] private GameObject coinEast = null;
    [SerializeField] private Transform[] moneySpawn = null;

    private void Start() 
    {
        currentHealth = maxHealth;
        healthScr.SetMaxHealth(maxHealth);
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag(bulletTag)) {
            damage(2);
        }
    }
     public void damage(int damage)
    {
        if(phaseManager.buildPhase == false && phaseManager.fightPhase == true) {
            currentHealth -= damage;
            healthScr.SetHealth(currentHealth);

            switch(playerSide) {
                case "west":
                    meshes[0].material = colors[1];
                    StartCoroutine(backToNormal());
                    break;
                case "east": 
                    meshes[1].material = colors[1];
                    StartCoroutine(backToNormal());
                    break;
            }
            if(currentHealth <= 0 && dead == false) {
                dead = true;
                Instantiate(explosion, transform.position, transform.rotation);
                destroy(playerSide);
            }
        }
    }
    private IEnumerator backToNormal()
    {
        yield return new WaitForSeconds(0.5f);
        switch(playerSide) {
            case "west":
                meshes[0].material = colors[0];
                break;
            case "east":
                meshes[1].material = colors[2];
                break;
        }
    }

    public void destroy(string scriptName)
    {
        switch(scriptName)  
        {
            case "west":
                towerManagement.removeTransformEast(this.transform);
                switch(towerType) {
                    case "shot":
                        phaseManager.towerWest.Remove(this.gameObject);
                        Instantiate(coinWest,transform.position, transform.rotation);
                        break;
                        case "money":
                        phaseManager.moneyTowerWest.Remove(this.gameObject);
                        for(int index = 0; index < 2; index++) {
                            Instantiate(coinWest, moneySpawn[index].position, transform.rotation);
                        }
                        break;
                    case "rocket":
                        phaseManager.rocketTowerWest.Remove(this.gameObject);
                        for(int index = 0; index < 2; index++) {
                            Instantiate(coinWest, moneySpawn[index].position, transform.rotation);
                        }
                        break;
                    case "ice":
                        phaseManager.iceTowerWest.Remove(this.gameObject);
                        for(int index = 0; index < 2; index++) {
                            Instantiate(coinWest, moneySpawn[index].position, transform.rotation);
                        }
                        break;
                    case "cover":
                        Instantiate(coinWest,transform.position, transform.rotation);
                        break;
                }
                StopAllCoroutines();
                Destroy(gameObject);
                break;
            case "east":
                towerManagement.removeTransformWest(this.transform);
                switch(towerType) {
                    case "shot":
                        phaseManager.towerEast.Remove(this.gameObject);
                        Instantiate(coinEast, transform.position, transform.rotation);
                        break;
                    case "money":
                        phaseManager.moneyTowerEast.Remove(this.gameObject);
                        for(int index = 0; index < 2; index++) {
                            Instantiate(coinEast, moneySpawn[index].position, transform.rotation);
                        }
                        break;
                    case "rocket":
                        phaseManager.rocketTowerEast.Remove(this.gameObject);
                        for(int i = 0; i < 2; i++) {
                            Instantiate(coinEast, moneySpawn[i].position, transform.rotation);
                        }
                        break;
                    case "ice":
                        phaseManager.iceTowerEast.Remove(this.gameObject);
                        for(int i = 0; i < 2; i++) {
                            Instantiate(coinEast, moneySpawn[i].position, transform.rotation);
                        }
                        break;
                    case "cover":
                        Instantiate(coinEast, transform.position, transform.rotation);
                        break;
                }
                StopAllCoroutines();
                Destroy(gameObject);
                break;
        }
    }
}
