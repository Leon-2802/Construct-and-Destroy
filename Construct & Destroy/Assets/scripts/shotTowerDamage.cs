using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotTowerDamage : MonoBehaviour
{
    public healthbar healthScr;
    [SerializeField] private int maxHealth = 20;
    private int currentHealth = 0;
    // public towerManagement towerManagement = null;
    // public phaseManager phaseManager;
    [SerializeField] private GameObject explosion = null;
    public shotTowerWest westScr = null;
    public shotTowerEast eastScr = null;
    [SerializeField] private string bulletTag = null;
    [SerializeField] private string playerSide = null;
    [SerializeField] private MeshRenderer[] meshes = null;
    [SerializeField] private Material[] colors = null;

    private void Start() 
    {
        currentHealth = maxHealth;
        healthScr.SetMaxHealth(maxHealth);
        // towerManagement = GameObject.FindWithTag("towerManagement").GetComponent<towerManagement>();
        // phaseManager = GameObject.FindWithTag("phaseManager").GetComponent<phaseManager>();
    }


    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag(bulletTag)) {
            damage(2);
        }
    }
     public void damage(int damage)
    {
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
        if(currentHealth <= 0) {
            Instantiate(explosion, transform.position, transform.rotation);
            destroy(playerSide);
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
                // towerManagement.removeTransformWest(this.transform);
                StopAllCoroutines();
                // westScr.destroyed = true;
                // Destroy(gameObject);
                break;
            case "east":
                // towerManagement.removeTransformEast(this.transform);
                // phaseManager.towerEast.Remove(this.gameObject);
                StopAllCoroutines();
                // eastScr.destroyed = true;
                // Destroy(gameObject);
                break;
        }
    }
}
