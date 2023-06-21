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
    public GameObject autoDeath;

    // Update is called once per frame
    private void Start()
    {
        DP.text = "DP: " + dashMeter;
    }

    public void AddDashMeter()
    {
        dashMeter += 5;
        DP.text = "DP: " + dashMeter;
        
        if(dashMeter == dashMeterFull)
        {
            dashButton.gameObject.SetActive(true);
        }
    }

    public void OnDash()
    {
        DP.text = "DP: " + dashMeter;
        StartCoroutine(BoostCount());
    }

    
    //Calls SpawnManager so that code can get each enemy and adjust their speed;
    IEnumerator BoostCount()
    {
        dashMeter = 0;
        dashButton.gameObject.SetActive(false);

        autoDeath.gameObject.SetActive(true);
        //Makes things faster
        Time.timeScale = 2.0f;   
        yield return new WaitForSeconds(7);

        Time.timeScale = 1.0f;
        autoDeath.gameObject.SetActive(false);
    }
    
}
