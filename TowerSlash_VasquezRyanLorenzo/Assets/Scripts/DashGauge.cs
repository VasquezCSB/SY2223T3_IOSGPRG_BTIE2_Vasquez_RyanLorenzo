using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DashGauge : MonoBehaviour
{
    public float dashMeter;
    private float dashMeterFull = 100;//100

    public Button dashButton;
    public Image dashBar;

    public GameObject autoDeath;

    public void AddDashMeter()
    {
        dashMeter += 5;
        dashBar.fillAmount = dashMeter / 100f;
        
        if(dashMeter == dashMeterFull)
        {
            dashButton.gameObject.SetActive(true);
        }
    }

    public void OnDash()
    {
        StartCoroutine(BoostCount());
    }

    
    //Calls SpawnManager so that code can get each enemy and adjust their speed;
    IEnumerator BoostCount()
    {
        dashMeter = 0;

        dashBar.fillAmount = 0;
        dashButton.gameObject.SetActive(false);
        autoDeath.gameObject.SetActive(true);

        //Makes things faster
        Time.timeScale = 2.0f;   
        yield return new WaitForSeconds(7);

        Time.timeScale = 1.0f;
        autoDeath.gameObject.SetActive(false);
    }
    
}
