using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRotation : MonoBehaviour
{
    [SerializeField] private float speed = 0;
    [SerializeField] private Transform center = null;
    void Update()
    {
        transform.RotateAround(center.position, center.up, Time.deltaTime * speed);
    }
}
