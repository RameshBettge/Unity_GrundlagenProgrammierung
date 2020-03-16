using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionColor : MonoBehaviour
{
    Color posColor;

    void Update()
    {
        SetPosColor();
        ApplyPosColor();
    }


    void SetPosColor()
    {
        Vector3 pos = transform.position;
        //posColor = new Color(transform.position.x, transform.position.y, transform.position.z);
        posColor = new Color(pos.x, pos.y, pos.z);
    }


    private void ApplyPosColor()
    {
        GetComponent<MeshRenderer>().material.color = posColor;
    }
}
