using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundFeedback : MonoBehaviour
{
    [SerializeField] private Material normal = null;
    [SerializeField] private Material feedback = null;
    [SerializeField] private MeshRenderer mesh = null;
    public phaseManager phaseManager;
    void Start()
    {
        phaseManager = GameObject.FindWithTag("phaseManager").GetComponent<phaseManager>();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("towerWest") || other.CompareTag("towerEast") || other.CompareTag("coverWest") || other.CompareTag("coverEast")) {
            if(phaseManager.buildPhase == true && phaseManager.fightPhase == false) {
                Material[] mats = mesh.materials;
                mats[1] = feedback;
                mesh.materials = mats;
            }
        }
    }

    private void OnTriggerStay(Collider other) {
        if(other.CompareTag("towerWest") || other.CompareTag("towerEast") || other.CompareTag("coverWest") || other.CompareTag("coverEast")) {
            if(phaseManager.buildPhase == true && phaseManager.fightPhase == false) {
                Material[] mats = mesh.materials;
                mats[1] = feedback;
                mesh.materials = mats;
            }
            else {
                Material[] mats = mesh.materials;
                mats[1] = normal;
                mesh.materials = mats;
            }
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.CompareTag("towerWest") || other.CompareTag("towerEast") || other.CompareTag("coverWest") || other.CompareTag("coverEast")) {
            if(phaseManager.buildPhase == true && phaseManager.fightPhase == false) {
                Material[] mats = mesh.materials;
                mats[1] = normal;
                mesh.materials = mats;
            }
        }
    }
}
