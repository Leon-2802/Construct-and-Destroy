using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketTowerY : MonoBehaviour
{
    [SerializeField] private float yPos = 0.65f;
    void Start()
    {
        Vector3 newPos = transform.position;
        newPos.y = yPos;
        transform.position = newPos;
    }
}
