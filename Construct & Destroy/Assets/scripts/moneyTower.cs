﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneyTower : MonoBehaviour
{
    [SerializeField] private GameObject coin = null;
    [SerializeField] private Transform[] moneySpawns = null;

    public void callFirstCoroutine() {
        StartCoroutine(moneyInt());
    }

    private IEnumerator moneyInt()
    {
        yield return new WaitForSeconds(6f);
        for(int i = 0; i < 2; i++) {
            Instantiate(coin, moneySpawns[i].position, moneySpawns[i].rotation);
        }
        yield return new WaitForSeconds(20f);
        callFirstCoroutine();
    }
}
