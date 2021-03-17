using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class playerEastControl : MonoBehaviour
{
    //Inputs:
    KeyboardControls inputCtrl;

    //Movement
    Vector2 Move;
    Vector2 rotate;
    public Rigidbody rb = null;
    [SerializeField] public float speed = 15f;
    public Camera cam = null;

    //Shoot:
    public GameObject bulletPrefab;
    [SerializeField] private Transform firePointSouth = null;
    [SerializeField] private Transform firePointNorth = null;
    [SerializeField] private float bulletSpeed = -20;
    private bool canShoot = true;

    //laser:
    public GameObject laserPrefab;
    [SerializeField] private Transform laserSpawn = null;
    private GameObject laser;
    public bool laserOk = true;

     //rocket:
    public GameObject rocketPrefab;
    [SerializeField] private Transform rocketSpawn = null;
    [SerializeField] private float rocketSpeed = 15;
    public bool rocketOk = true;

    //UI:
    public changeGunsUI changeGunsUI;
    [SerializeField] private rechargeSlider[] recharge = null;

    //Money:
    public int moneyEast;
    public phaseManager phaseManager;
    [SerializeField] private Text moneyTxt = null;

    void Awake() 
    {
        inputCtrl = new KeyboardControls();
        
        inputCtrl.gameplayEast.walk.performed += ctx => Move = ctx.ReadValue<Vector2>().normalized;
        inputCtrl.gameplayEast.walk.canceled += ctx => Move = Vector2.zero;

        inputCtrl.gameplayEast.rotate.performed += ctx => rotate = ctx.ReadValue<Vector2>();
        inputCtrl.gameplayEast.rotate.canceled += ctx => rotate = Vector2.zero;

        inputCtrl.gameplayEast.shootBullet.performed += ctx => Shoot();

        inputCtrl.gameplayEast.laserWirbel.performed += ctx => Wirbel();

        inputCtrl.gameplayEast.rocketShot.performed += ctx => shootRocket();
    }
    //other stuff:
    private void Start() {
        moneyEast = phaseManager.moneyEast;
        moneyTxt.text = moneyEast.ToString();
    }
    public void resetAbillities() {
        canShoot = true;
        changeGunsUI.resetUIEast(0);
        recharge[0].intervall = recharge[0].maxTime;
        recharge[0].setMaxTime(recharge[0].intervall);
        laserOk = true;
        changeGunsUI.resetUIEast(1);
        recharge[1].intervall = recharge[1].maxTime;
        recharge[1].setMaxTime(recharge[1].intervall);
        rocketOk = true;
        changeGunsUI.resetUIEast(2);
        recharge[2].intervall = recharge[2].maxTime;
        recharge[2].setMaxTime(recharge[2].intervall);
        setMoneyText();
    }
    public void setMoneyText() {
        moneyTxt.text = moneyEast.ToString();
    }

    //Input-Stuff:
    void Update()
    {
        Vector3 m = new Vector3(Move.x, 0, Move.y) * Time.deltaTime * speed;
        Vector3 newPos = transform.position + m;
        rb.MovePosition(newPos);

        Ray ray = cam.ScreenPointToRay(rotate);
        if(Physics.Raycast(ray, out RaycastHit hit)) {
            Vector3 lookAtMouse = hit.point;
            lookAtMouse.y = transform.position.y;
            Vector3 dir = lookAtMouse - transform.position;
            dir = -dir;
            //ohne den oberen zwei Zeilen für normalen drehen
            transform.LookAt(transform.position + dir);
        }
        
    }

     void Shoot()
    {
        if (canShoot == true) {
            StartCoroutine(shootIntervall());
        }
    }
    private IEnumerator shootIntervall()
    {
        soundManager.sManagerInstance.Audio.PlayOneShot(soundManager.sManagerInstance.shot);
        canShoot = false;
        changeGunsUI.greyUIEast(0);
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
        changeGunsUI.resetUIEast(0);
    }

    void Wirbel()
    {
        if (laserOk == true) {
            GameObject laser = Instantiate(laserPrefab, laserSpawn.position, laserSpawn.rotation);
            laser.transform.parent = transform;
            laserOk = false;
            changeGunsUI.greyUIEast(1);
            recharge[1].intervall = 0f;
            recharge[1].moveUp = true;
            StartCoroutine(laserIntervall());
        }
    }
    private IEnumerator laserIntervall() 
    {
        yield return new WaitForSeconds(10f);
        laserOk = true;
        changeGunsUI.resetUIEast(1);
    }

     void shootRocket() {
        if (rocketOk == true) {
            GameObject rocket = Instantiate(rocketPrefab, rocketSpawn.position, rocketSpawn.rotation);
            Rigidbody rocketRb = rocket.GetComponent<Rigidbody>();
            rocketRb.AddForce(rocketSpawn.forward * rocketSpeed, ForceMode.Impulse);
            rocketOk = false;
            changeGunsUI.greyUIEast(2);
            recharge[2].intervall = 0f;
            recharge[2].moveUp = true;
            StartCoroutine(rocketIntervall());
        }
    }
    private IEnumerator rocketIntervall() {
        yield return new WaitForSeconds(20f);
        rocketOk = true;
        changeGunsUI.resetUIEast(2);
    }

    void OnEnable() {
        inputCtrl.gameplayEast.Enable();
    }
    void OnDisable() {
        inputCtrl.gameplayEast.Disable();
    }
}
