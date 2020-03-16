using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    string horizontalAxisName = "Horizontal";
    string verticalAxisName = "Vertical";

    // Update is called once per frame
    void Update()
    {
        // Wir lesen unseren Input aus.
        float horizontalInput = Input.GetAxis(horizontalAxisName);
        float verticalInput = Input.GetAxis(verticalAxisName);

        // Wir erstellen einen Vektoren aus unserem Input.
        Vector3 scaleChangeVector = new Vector3(horizontalInput, 0, verticalInput);

        // Wir benutzen unseren Vektoren, um die scale unseres Objektes zu verändern
        transform.localScale = transform.localScale + scaleChangeVector;
    }
}
