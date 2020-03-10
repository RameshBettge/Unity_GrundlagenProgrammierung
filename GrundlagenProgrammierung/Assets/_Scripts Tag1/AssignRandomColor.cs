using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignRandomColor : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Wir benutzen die Input Klasse um zu überprüfen, ob die Leertaste gedrückt wurde.
        bool spaceIsPressed = Input.GetKeyDown(KeyCode.Space);


        if (spaceIsPressed)
        {
            // Falls die Leertaste gedrückt wurde, wird dem Material eine zufällige Farbe zugewiesen.
            GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        }
    }
}
