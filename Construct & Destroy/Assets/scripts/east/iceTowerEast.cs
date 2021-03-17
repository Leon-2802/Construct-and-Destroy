using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iceTowerEast : MonoBehaviour
{
    private Transform target;
    public towerManagement towerManagement;
    [SerializeField] private Transform iceSpawn = null;
    [SerializeField] private GameObject icePrefab = null;
    [SerializeField] private float iceSpeed = 15f;

    public void callFirstShot() {
        target = towerManagement.targetsEast[0];
        StartCoroutine(firstShot());
    }
    private IEnumerator firstShot() {
        yield return new WaitForSeconds(2f);
        StartCoroutine(shootIce());
    }

    private IEnumerator shootIce() {
        Vector3 targetPos = target.position;
        Vector3 dir = target.position - target.position;
        targetPos.y = transform.position.y;
        transform.LookAt(targetPos);
        yield return new WaitForSeconds(0.1f);
        StartCoroutine(instantiate());
    }
    private IEnumerator instantiate() {
        soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.iceShot);
        GameObject ice = Instantiate(icePrefab, iceSpawn.position, iceSpawn.rotation);
        Rigidbody iceRb = ice.GetComponent<Rigidbody>();
        iceRb.AddForce(iceSpawn.forward * iceSpeed, ForceMode.Impulse);
        yield return new WaitForSeconds(8f);
        StartCoroutine(shootIce());
    }
}
