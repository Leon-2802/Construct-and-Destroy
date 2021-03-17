using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text TimerFight;
    [SerializeField] private float startTimeFight = 100;
    float currentTime = 0f;
    private bool stopTimer = false;
    public phaseManager phaseManager;

    void Start() 
    {
        setStartTime();
    }
    public void setStartTime()
    {
        currentTime = startTimeFight;
        stopTimer = false;
    }
    void Update()
    {
        if (currentTime <= 0 && stopTimer == false) {
            stopTimer = true;
            phaseManager.buildPhase = true;
            phaseManager.fightPhase = false;
            phaseManager.changePhase();
            // this.enabled = false;
        }
        else if (stopTimer == false) {
            currentTime -= Time.deltaTime;
            TimerFight.text = currentTime.ToString("0");
        }
    }
}
