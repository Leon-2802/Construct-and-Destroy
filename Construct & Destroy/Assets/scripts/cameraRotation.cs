using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cameraRotation : MonoBehaviour
{
    [SerializeField] private float speed = 0;
    [SerializeField] private Transform center = null;
    [SerializeField] private Transform check = null;
    public menuController menuController;
    private float angle;
    void Update()
    {
        transform.RotateAround(center.position, center.up, Time.deltaTime * speed);

        if(menuController.startBattle == true) {
            SceneManager.LoadScene("battle");

            Vector3 angleVector = check.position - transform.position;
            angle = Vector3.Angle(transform.forward, angleVector);
            // Debug.Log(angle);

            if(angle >= -0.5f && angle <= 0.5f) {
                speed = 0f;
            }
        }
    }
}
