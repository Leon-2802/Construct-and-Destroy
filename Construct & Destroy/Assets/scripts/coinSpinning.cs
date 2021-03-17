using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSpinning : MonoBehaviour
{
    public float spinSpeed;

    void Update()
    {
        transform.RotateAround(transform.position, transform.up, Time.deltaTime * spinSpeed);

    }
}
