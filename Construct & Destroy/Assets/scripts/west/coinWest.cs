using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinWest : MonoBehaviour
{
    [SerializeField] private GameObject targetScr = null;
    private bool touched = false;

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("playerEast") && touched == false) {
            soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.coin);
            touched = true;
            targetScr = other.gameObject;
            targetScr.GetComponent<playerEastControl>().moneyEast += 10;
            targetScr.GetComponent<playerEastControl>().setMoneyText();
            Destroy(gameObject);
        }
    }
}
