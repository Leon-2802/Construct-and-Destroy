using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freezeRotContrl : MonoBehaviour
{
    void Update()
    {
        Vector3 actualRot = transform.rotation.eulerAngles;
        actualRot.x = 0;
        actualRot.z = 0;
        transform.rotation = Quaternion.Euler(actualRot);
    }
}
