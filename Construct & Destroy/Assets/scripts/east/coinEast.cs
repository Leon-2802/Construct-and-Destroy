using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinEast : MonoBehaviour
{
    [SerializeField] private GameObject targetScr = null;
    private bool touched = false;

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("playerWest") && touched == false) {
            soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.coin);
            touched = true;
            targetScr = other.gameObject;
            targetScr.GetComponent<playerWestInput>().moneyWest += 10;
            targetScr.GetComponent<playerWestInput>().setMoneyText();
            Destroy(gameObject);
        }
    }
}
