using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freezeRotHealthbar : MonoBehaviour
{
    [SerializeField]
    private Transform cam = null;

    private void Start() {
        cam = GameObject.FindWithTag("MainCamera").transform;
    }
    void FixedUpdate()
    {
        transform.LookAt(transform.position + cam.forward);
    }
}
