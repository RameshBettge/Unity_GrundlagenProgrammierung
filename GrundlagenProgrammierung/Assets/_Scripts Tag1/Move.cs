using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 0.1f;

    public bool canMove = false;

    string horizontalAxisName = "Horizontal";
    string verticalAxisName = "Vertical";

    // Update is called once per frame
    void Update()
    {
        // Der code innerhalb der folgenden geschwungenen Klammern wird nur ausgeführt, wenn canMove auf 'true' gesetzt ist.
        if (canMove)
        {
            // Wir benutzen die Input-Klasse um den Wert einer Achse auszulesen. 
            // Dafür brauchen wir den Namen der Achse. 
            // Diesen haben wir oben bereits in einer variable gespeichert (horizontalAxisName = "Horizontal");
            // Den Wert speichern wir in einer neuen Variable namens horizontalInput.
            float horizontalInput = Input.GetAxis(horizontalAxisName);
            float verticalInput = Input.GetAxis(verticalAxisName);

            // Wir erstellen einen Vektor, da war diesen brauchen, um unsere Position zu verändern.
            // Wir erstellen ihn, indem wir unseren vertikalen und unseren horizontalen Input je einer von drei Achsen zuweisen.
            Vector3 moveVector = new Vector3(horizontalInput, 0, verticalInput);

            // Wir benutzen unseren Vektoren um unser position zu verändern.
            transform.position = transform.position + moveVector * speed;
        }
    }
}
