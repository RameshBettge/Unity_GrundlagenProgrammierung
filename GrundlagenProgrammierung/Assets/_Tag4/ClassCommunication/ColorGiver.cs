using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorGiver : MonoBehaviour
{
    public Color colorToGive;

    // Wir machen die Referenz zu einem ColorReveiver public, 
    // damit wir sie im Inspektor zuordnen können.
    public ColorReceiver myReceiver;

    void Update()
    {
        // Wir greifen auf eine Funktion namens ReceiveColor zu, 
        // die Teil vom ColorReceiver ist.
        // Als Parameter übergeben wir unsere colorToGive.
        myReceiver.ReceiveColor(colorToGive);
    }
}
