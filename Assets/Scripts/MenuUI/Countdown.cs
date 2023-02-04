using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisplay;

    public void Start()
    {
        StartCoroutine(CountdownToStart());
    }


    IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }

        countdownDisplay.text = "DIG!!!";
        
        yield return new WaitForSeconds(1f);
        
        countdownDisplay.gameObject.SetActive(false);
    }
}
