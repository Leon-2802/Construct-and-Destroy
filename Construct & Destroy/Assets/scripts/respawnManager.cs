using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnManager : MonoBehaviour
{
    public GameObject playerEast;
    public GameObject playerWest;
    public phaseManager phaseManager;
    [SerializeField] private Material blue = null;
    [SerializeField] private Material red = null;

    public void callRespawnEast() {
        StartCoroutine(respawnEast());
    }
    private IEnumerator respawnEast() {
        yield return new WaitForSeconds(3f);
        if(phaseManager.buildPhase == false && phaseManager.fightPhase == true) {
            playerEast.SetActive(true);
            playerEast.transform.position = new Vector3 (7f, 0.75f, 0f);
            playerEast.GetComponent<MeshRenderer>().material = blue;
            playerEast.GetComponent<playerEastControl>().resetAbillities();
            playerEast.GetComponent<hitProcessingEast>().startAgain();
        }
    }

    public void callRespawnWest() {
        StartCoroutine(respawnWest());
    }
    private IEnumerator respawnWest() {
        yield return new WaitForSeconds(3f);
        if(phaseManager.buildPhase == false && phaseManager.fightPhase == true) {
            playerWest.SetActive(true);
            playerWest.transform.position = new Vector3 (-9f, 0.75f, 0f);
            playerWest.GetComponent<MeshRenderer>().material = red;
            playerWest.GetComponent<playerWestInput>().resetAbillities();
            playerWest.GetComponent<hitProcessingWest>().startAgain();
        }
    }
}
