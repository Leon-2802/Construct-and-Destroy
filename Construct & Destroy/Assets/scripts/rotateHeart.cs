using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateHeart : MonoBehaviour
{
    [SerializeField] private MeshRenderer mesh = null;
    [SerializeField] private Material actualColor = null;
    void Start()
    {
        Vector3 rot = transform.rotation.eulerAngles;
        rot.x = -90;
        transform.rotation = Quaternion.Euler(rot);
        mesh.material = actualColor;
    }
}
