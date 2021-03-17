using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotTowerEast : MonoBehaviour
{
    public towerManagement towerManagement;
    [SerializeField] public Transform target = null;
    [SerializeField] private Transform spawnBulletN = null;
    [SerializeField] private Transform spawnBulletS = null;
    [SerializeField] private GameObject bulletEastPref = null;
    [SerializeField] private float bulletSpeed = 10;
    void Update()
    {
        if(target == null) {
            StopAllCoroutines();
            selectTarget();
        }
    }
    private void selectTarget() {
        System.Random rnd = new System.Random();
        int random2 = Random.Range(0, towerManagement.targetsEast.Count);
        target = towerManagement.targetsEast[random2];
        StartCoroutine(shootInt());
    }

    private IEnumerator shootInt() 
    {
        Vector3 targetPos = target.position;
        Vector3 dir = target.position - target.position;
        targetPos.y = transform.position.y;
        float rndX = Random.Range(0f, 1f);
        float rndZ = Random.Range(0f, 1f);
        targetPos.x += rndX;
        targetPos.z += rndZ;
        transform.LookAt(targetPos);

        yield return new WaitForSeconds(0.4f);

        soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.shot);
        GameObject bullet = Instantiate(bulletEastPref, spawnBulletS.position, spawnBulletS.rotation);
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
        bulletRb.AddForce(spawnBulletS.right * bulletSpeed, ForceMode.Impulse);

        GameObject bullet2 = Instantiate(bulletEastPref, spawnBulletN.position, spawnBulletN.rotation);
        Rigidbody bullet2Rb = bullet2.GetComponent<Rigidbody>();
        bullet2Rb.AddForce(spawnBulletN.right * bulletSpeed, ForceMode.Impulse);
        
        yield return new WaitForSeconds(2.1f);
        selectTarget(); 
    }
}
