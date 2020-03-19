using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicColor : MonoBehaviour
{
    public Color myColor;


    // Update is called once per frame
    void Update()
    {
        GetComponent<Renderer>().material.color = myColor;
    }
}
