using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationControls : MonoBehaviour
{
    [SerializeField] private float duration = 1;
    [SerializeField] private int rounds = 3;
    float durationLeft = 0;

    private void Start() {
        durationLeft = duration;
    }
    private void Update() {
        float rot = (360 * rounds * Time.deltaTime) / duration;
        Vector3 actualRot = transform.rotation.eulerAngles;
        actualRot.y += rot;
        transform.rotation = Quaternion.Euler(actualRot);
        durationLeft -= Time.deltaTime;
        if(durationLeft <= 0) {
            DestroyImmediate(this.gameObject);
        }
    }
}
