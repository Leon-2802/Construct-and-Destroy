using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserEastHit : MonoBehaviour
{
    public hitProcessingWest plyWestScr;
    // public towerDamage towerScr;
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("playerWest")) {
            other.GetComponent<hitProcessingWest>().Hurt(3);
        }
        else if(other.CompareTag("towerWest")) {
            other.GetComponent<towerDamage>().damage(3);
        }
        else if(other.CompareTag("coverWest")) {
            other.GetComponent<towerDamage>().damage(3);
        }
    }
}
