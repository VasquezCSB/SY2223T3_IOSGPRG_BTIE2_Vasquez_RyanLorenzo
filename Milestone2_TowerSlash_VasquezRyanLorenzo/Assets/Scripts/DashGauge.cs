using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DashGauge : MonoBehaviour
{
    public int dashMeter;
    private int dashMeterFull = 100;//100
    public TMP_Text DP;
    public Button dashButton;

    // Update is called once per frame
    private void Start()
    {
        DP.text = "DP: " + dashMeter;

    }

    public void addDashMeter()
    {
        dashMeter += 5;
        DP.text = "DP: " + dashMeter;
        
        if(dashMeter == dashMeterFull)
        {
            dashButton.gameObject.SetActive(true);
        }
    }

    public void onDash()
    {
        DP.text = "DP: " + dashMeter;
        StartCoroutine(boostCount());
    }

    
    //Calls SpawnManager so that code can get each enemy and adjust their speed;
    IEnumerator boostCount()
    {
        dashMeter = 0;
        dashButton.gameObject.SetActive(false);

        //Makes things faster
        Time.timeScale = 2.0f;   

        yield return new WaitForSeconds(7);

        Time.timeScale = 1.0f;
        
    }
    
}
