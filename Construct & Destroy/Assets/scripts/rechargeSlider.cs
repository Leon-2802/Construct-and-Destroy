using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rechargeSlider : MonoBehaviour
{
    [SerializeField] private Slider slider = null;
    public float maxTime = 0;
    public float intervall;
    public bool moveUp = false;
    void Start()
    {
        intervall = maxTime;
        setMaxTime(intervall);
    }
    private void Update() {
        if(moveUp == true) {
            intervall += Time.deltaTime;
            setCurrenTime(intervall);
            if(intervall >= maxTime) {
                moveUp = false;
            }
        }
    }

    // Update is called once per frame
    public void setMaxTime(float intervall)
    {
        slider.maxValue = intervall;
        slider.value = intervall;
        moveUp = false;
    }

    private void setCurrenTime(float intervall) {
        slider.value = intervall;
    }
}
