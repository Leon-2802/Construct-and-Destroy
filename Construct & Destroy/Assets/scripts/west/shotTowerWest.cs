using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotTowerWest : MonoBehaviour
{
    public towerManagement towerManagement;
    [SerializeField] public Transform target;
    [SerializeField] private Transform spawnBulletN = null;
    [SerializeField] private Transform spawnBulletS = null;
    [SerializeField] private GameObject bulletWestPref = null;
    [SerializeField] private float bulletSpeed = 10;
    void Update()
    {
        if(target == null) {
            StopAllCoroutines();
            selectTarget();
        }
    }
     private void selectTarget()
    {
        System.Random rnd = new System.Random();
        int random = Random.Range(0, towerManagement.targetsWest.Count);
        target = towerManagement.targetsWest[random];
        StartCoroutine(shootInt());
    }

    private IEnumerator shootInt() 
    {
        Vector3 targetPos = target.position;
        targetPos.y = transform.position.y;
        float rndX = Random.Range(0f, 2f);
        float rndZ = Random.Range(0f, 2f);
        targetPos.x += rndX;
        targetPos.z += rndZ;
        transform.LookAt(targetPos);

        yield return new WaitForSeconds(0.2f);
    
        soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.shot);
        for(int i = 0; i < 2; i++) {
            GameObject bullet = Instantiate(bulletWestPref, spawnBulletS.position, spawnBulletS.rotation);
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.AddForce(spawnBulletS.right * bulletSpeed, ForceMode.Impulse);
        }
        GameObject bullet2 = Instantiate(bulletWestPref, spawnBulletN.position, spawnBulletN.rotation);
        Rigidbody bullet2Rb = bullet2.GetComponent<Rigidbody>();
        bullet2Rb.AddForce(spawnBulletN.right * bulletSpeed, ForceMode.Impulse);

        yield return new WaitForSeconds(1f);
        selectTarget();    
    }
}
