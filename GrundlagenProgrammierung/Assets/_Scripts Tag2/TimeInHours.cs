using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeInHours : MonoBehaviour
{
    public float timeInMinutes;

    void Update()
    {
        float timeInHours = timeInMinutes / 60;

        print(timeInHours);

        float timeInSeconds = Time.time;

        float actualTimeInMinutes = timeInSeconds / 60;

        //print(actualTimeInMinutes);

            //print(timeInHours + ":" + timeInMinutes)
    }
}
