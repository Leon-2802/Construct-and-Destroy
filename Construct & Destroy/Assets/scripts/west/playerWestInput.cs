using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class playerWestInput : MonoBehaviour
{
    Rigidbody rb;
    PlayerControls controls;
    Vector2 Move;
    Vector2 rotate;
    [SerializeField] public float speed = 15f;
    //bullet:
    public GameObject bulletPrefab;
    [SerializeField] private Transform firePointSouth = null;
    [SerializeField] private Transform firePointNorth = null;
    [SerializeField] private float bulletSpeed = 20;
    public bool canShoot = true;
    //rocket:
    public GameObject rocketPrefab;
    [SerializeField] private Transform rocketSpawn = null;
    [SerializeField] private float rocketSpeed = 15;
    public bool rocketOk = true;
    //laser:
    public GameObject laserPrefab;
    [SerializeField] private Transform laserSpawn = null;
    private GameObject laser;
    public bool laserOk = true;
    //UI:
    public changeGunsUI changeGunsUI;
    [SerializeField] private rechargeSlider[] recharge = null;
    //money:
    public int moneyWest;
    public phaseManager phaseManager;
    [SerializeField] private Text moneyTxt = null;
    void Awake() 
    {
        rb = GetComponent<Rigidbody>();
        controls = new PlayerControls();

        controls.gameplay.Walk.performed += context => Move = context.ReadValue<Vector2>().normalized;
        controls.gameplay.Walk.canceled += context => Move = Vector2.zero;

        controls.gameplay.Rotate.performed += context => rotate = context.ReadValue<Vector2>().normalized;
        controls.gameplay.Rotate.canceled += context => rotate = Vector2.zero;

        controls.gameplay.shootBullet.performed += context => Shoot();

        controls.gameplay.laserWirbel.performed += context => Wirbel();

        controls.gameplay.Rocket.performed += context => shootRocket();
    }
    //other stuff:
    private void Start() {
        moneyWest = phaseManager.moneyWest;
        moneyTxt.text = moneyWest.ToString();
    }
    public void resetAbillities() {
        canShoot = true;
        changeGunsUI.resetUIWest(0);
        recharge[0].intervall = recharge[0].maxTime;
        recharge[0].setMaxTime(recharge[0].intervall);
        laserOk = true;
        changeGunsUI.resetUIWest(1);
        recharge[1].intervall = recharge[1].maxTime;
        recharge[1].setMaxTime(recharge[1].intervall);
        rocketOk = true;
        changeGunsUI.resetUIWest(2);
        recharge[2].intervall = recharge[2].maxTime;
        recharge[2].setMaxTime(recharge[2].intervall);
        setMoneyText();
    }
    public void setMoneyText() {
        moneyTxt.text = moneyWest.ToString();
    }

    //input-stuff:
    void Update()
    {
        Vector3 m = new Vector3(Move.x, 0, Move.y) * Time.deltaTime * speed;
        Vector3 newPos = transform.position + m;
        rb.MovePosition(newPos);

        Vector3 lookAtPos = transform.position;
        lookAtPos += new Vector3(rotate.x, 0f, rotate.y);
        Vector3 dir = lookAtPos - transform.position;
        // dir = -dir;
        //normale Drehung ohne den obere Zeile
        transform.LookAt(transform.position + dir);
    }

    void Shoot()
    {
        if (canShoot == true) {
            StartCoroutine(shootIntervall());
        }
    }

    private IEnumerator shootIntervall()
    {
        //sound:
        soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.shot);
        canShoot = false;
        changeGunsUI.greyUIWest(0);
        recharge[0].intervall = 0f;
        recharge[0].moveUp = true;
        GameObject bullet = Instantiate(bulletPrefab, firePointSouth.position, firePointSouth.rotation);
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
        bulletRb.AddForce(firePointSouth.forward * bulletSpeed, ForceMode.Impulse);

        GameObject bullet2 = Instantiate(bulletPrefab, firePointNorth.position, firePointNorth.rotation);
        Rigidbody bullet2Rb = bullet2.GetComponent<Rigidbody>();
        bullet2Rb.AddForce(firePointNorth.forward * bulletSpeed, ForceMode.Impulse);
        yield return new WaitForSeconds(0.5f);
        canShoot = true;
        changeGunsUI.resetUIWest(0);
    }

    void Wirbel()
    {
        if (laserOk == true) {
            GameObject laser = Instantiate(laserPrefab, laserSpawn.position, laserSpawn.rotation);
            laser.transform.parent = transform;
            laserOk = false;
            changeGunsUI.greyUIWest(1);
            recharge[1].intervall = 0f;
            recharge[1].moveUp = true;
            StartCoroutine(laserIntervall());
        }
    }
    private IEnumerator laserIntervall() 
    {
        yield return new WaitForSeconds(10f);
        laserOk = true;
        changeGunsUI.resetUIWest(1);
    }

    void shootRocket() {
        if (rocketOk == true) {
            GameObject rocket = Instantiate(rocketPrefab, rocketSpawn.position, rocketSpawn.rotation);
            Rigidbody rocketRb = rocket.GetComponent<Rigidbody>();
            rocketRb.AddForce(rocketSpawn.forward * rocketSpeed, ForceMode.Impulse);
            rocketOk = false;
            changeGunsUI.greyUIWest(2);
            recharge[2].intervall = 0f;
            recharge[2].moveUp = true;
            StartCoroutine(rocketIntervall());
        }
    }
    private IEnumerator rocketIntervall() {
        yield return new WaitForSeconds(20f);
        rocketOk = true;
        changeGunsUI.resetUIWest(2);
    }

    void OnEnable() 
    {
        controls.gameplay.Enable();
    }
    void OnDisable() 
    {
        controls.gameplay.Disable();
    }
}
