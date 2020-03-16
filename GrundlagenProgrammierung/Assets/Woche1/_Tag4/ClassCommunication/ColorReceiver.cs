using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorReceiver : MonoBehaviour
{
    // Diese Funktion wird ausgeführt,
    // wenn sie vom ColorGiver aufgerufen wird.
    public void ReceiveColor(Color receivedColor)
    {
        // Wir setzen die Farbe unseres Materials auf die Farbe,
        // die der Funktion als Parameter in übergeben wurde.
        GetComponent<MeshRenderer>().material.color = receivedColor;
    }
}
