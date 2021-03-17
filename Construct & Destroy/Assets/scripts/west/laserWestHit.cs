using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserWestHit : MonoBehaviour
{
    public hitProcessingEast plyEastScr;
    // public towerDamage towerScr;

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("playerEast")) {
            other.GetComponent<hitProcessingEast>().Hurt(3);
        }
        else if(other.CompareTag("towerEast")) {
            other.GetComponent<towerDamage>().damage(3);
        }
        else if(other.CompareTag("coverEast")) {
            other.GetComponent<towerDamage>().damage(3);
        }
    }
}
