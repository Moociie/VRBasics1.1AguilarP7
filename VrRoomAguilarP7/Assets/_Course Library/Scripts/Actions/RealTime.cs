using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealTime : MonoBehaviour
{
    private Transform secondHand;
    private Transform minuteHand;
    private Transform hourHand;


    string mySeconds = "00";

    // Start is called before the first frame update
    public void Update()
    {
        string seconds = System.DateTime.UtcNow.ToString("ss");

        if(seconds != mySeconds)
        {
            UpdateTimer();
        }
        mySeconds = seconds;
    }

    // Update is called once per frame
    void UpdateTimer()
    {
        int secondsInt = int.Parse(System.DateTime.Now.ToString("ss"));
        int minuteInt = int.Parse(System.DateTime.Now.ToString("mm"));
        int hourInt = int.Parse(System.DateTime.Now.ToString("hh"));

        print("Time = " + hourInt + ":" + minuteInt + ":" + secondsInt);

        hourHand.localRotation = Quaternion.Euler(hourInt * 30f, 0, 0);
        minuteHand.localRotation = Quaternion.Euler(minuteInt * 6f, 0, 0);
        secondHand.localRotation = Quaternion.Euler(secondsInt * 6f, 0, 0);

    }
}
