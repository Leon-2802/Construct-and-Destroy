using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrikadeWest : MonoBehaviour
{
    public healthbar healthbar;
    [SerializeField] private int health = 50;
    private int currentHealth;
    void Start()
    {
        healthbar.SetMaxHealth(health);
        currentHealth = health;
    }

    
}
