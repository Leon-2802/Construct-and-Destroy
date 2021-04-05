using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cameraRotation : MonoBehaviour
{
    [SerializeField] private float speed = 0;
    [SerializeField] private float zoomSpeed = 15f;
    [SerializeField] private float zoomTime = 3f;
    [SerializeField] private Transform center = null;
    public menuController menuController;
    private bool rotated = false;
    void Update()
    {
        transform.RotateAround(center.position, center.up, Time.deltaTime * speed);

        if(menuController.startBattle == true) {
            speed = 0f;
            
            if(rotated == false) {
               rotateBack();
            }

            transform.Translate(Vector3.forward * zoomSpeed * Time.deltaTime);
            zoomTime -= Time.deltaTime;

            if(zoomTime <= 0) {
                zoomSpeed = 0f;
                SceneManager.LoadScene("battle");
            }
        }
    }

    void rotateBack() {
        rotated = true;
        //zu kamera rotieren:
        transform.position = new Vector3(-0.25f, 10.39f, -24.69f);
        Vector3 actualRot = transform.rotation.eulerAngles;
        actualRot.x = 17.998f;
        actualRot.y = 0;
        actualRot.z = 0;
        transform.rotation = Quaternion.Euler(actualRot);
    }
}
