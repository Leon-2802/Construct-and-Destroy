using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerBuild : MonoBehaviour
{
    public Text Timer;
    [SerializeField] private float startTime = 25;
    float currentTime = 0f;
    private bool stopTimer = false;
    public phaseManager phaseManager;

    void Start() 
    {
        setStartTime();
    }
    public void setStartTime()
    {
        currentTime = startTime;
        stopTimer = false;
    }
    void Update()
    {
        if (currentTime <= 0 && stopTimer == false) {
            stopTimer = true;
            phaseManager.buildPhase = false;
            phaseManager.fightPhase = true;
            phaseManager.changePhase();
            // this.enabled = false;
        }
        else if (stopTimer == false) {
            currentTime -= Time.deltaTime;
            Timer.text = currentTime.ToString("0");
        }
    }
}
