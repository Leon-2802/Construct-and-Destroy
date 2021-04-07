using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rangeSpheresWest : MonoBehaviour
{
    [SerializeField] private GameObject spherePrefab = null;
    private GameObject sphere;

    public void spawnSphere(float value, Transform spawn) {
        sphere = Instantiate(spherePrefab, spawn.position, Quaternion.identity);
        sphere.transform.localScale = new Vector3(value, 4f, value);
        sphere.transform.SetParent(spawn);
    }

    public void destroySphere() {
        Destroy(sphere);
    }
}
