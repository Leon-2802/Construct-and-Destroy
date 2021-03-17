using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parentTowerCanvas : MonoBehaviour
{
    [SerializeField] private GameObject healthbar = null;
    [SerializeField] private GameObject tower = null;

    private void Start() {
        healthbar.transform.SetParent(tower.transform);
    }
}
