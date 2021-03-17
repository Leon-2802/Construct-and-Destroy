using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletEast : MonoBehaviour
{
    private void Start() {
        Destroy(gameObject, 0.5f);
    }
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("playerWest") || other.CompareTag("Wall") || other.CompareTag("towerWest") || other.CompareTag("coverWest")) {
            Destroy(gameObject);
        }
    }
}
