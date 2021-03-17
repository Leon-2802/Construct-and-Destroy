using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketTowerWest : MonoBehaviour
{
    private Transform target;
    public towerManagement towerManagement;
    [SerializeField] private Transform rocketSpawn = null;
    [SerializeField] private GameObject rocketPrefab = null;
    [SerializeField] private float rocketSpeed = 15f;
    private bool rocketOk = false;

    public void callFirstShot() {
        target = towerManagement.targetsWest[0];
        StartCoroutine(firstShot());
    }
    private IEnumerator firstShot() {
        yield return new WaitForSeconds(2f);
        rocketOk = true;
    }

    void Update()
    {
        if(rocketOk == true) {
            StartCoroutine(shootInt());
        }
    }

    private IEnumerator shootInt() 
    {
        rocketOk = false;
        Vector3 targetPos = target.position;
        Vector3 dir = target.position - target.position;
        targetPos.y = transform.position.y;
        // float rndX = Random.Range(0f, 1f);
        // float rndZ = Random.Range(0f, 1f);
        // targetPos.x += rndX;
        // targetPos.z += rndZ;
        transform.LookAt(targetPos);

        yield return new WaitForSeconds(0.8f);
        StartCoroutine(shootRocket());
    }

    private IEnumerator shootRocket() {
        GameObject rocket = Instantiate(rocketPrefab, rocketSpawn.position, rocketSpawn.rotation);
        Rigidbody rocketRb = rocket.GetComponent<Rigidbody>();
        rocketRb.AddForce(rocketSpawn.forward * rocketSpeed, ForceMode.Impulse);
        yield return new WaitForSeconds(5f);
        rocketOk = true;
    }

}
