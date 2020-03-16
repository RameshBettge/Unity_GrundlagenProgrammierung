using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketFire : MonoBehaviour
{
    public bool isThrusting = false;
    Vector3 startSize;

    float scaleMultiplier = 1;
    public float minScaleMultiplier = 0.2f;
    public float scaleChangePerSecond = 2;

    private void Start()
    {
        startSize = transform.localScale;
        transform.localScale = startSize * scaleMultiplier;
    }

    private void LateUpdate()
    {
        GetTargetScale();
        ChangeScale();
        isThrusting = false;
    }


    private void GetTargetScale()
    {
        if (isThrusting)
        {
            scaleMultiplier += scaleChangePerSecond * Time.deltaTime;
        }
        if (!isThrusting)
        {
            scaleMultiplier -= scaleChangePerSecond * Time.deltaTime;
        }

        if (scaleMultiplier > 1)
        {
            scaleMultiplier = 1;
        }
        if (scaleMultiplier < minScaleMultiplier)
        {
            scaleMultiplier = minScaleMultiplier;
        }
    }


    private void ChangeScale()
    {
        transform.localScale = startSize * scaleMultiplier;
    }


}
