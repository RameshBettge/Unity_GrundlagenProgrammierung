using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Start()
    {
        int result = SubtractNumbers(2, 4);


        bool spaceIsPressed = Input.GetKey(KeyCode.Space);

        bool  spaceIsPressedDown = Input.GetKeyDown(KeyCode.Space);

        if (spaceIsPressed)
        {

        }


        float hInput = Input.GetAxis("Horizontal");
        float hInputRaw = Input.GetAxisRaw("Horizontal");
    }



    Vector3 MoveTransform(Transform givenTransform)
    {
        givenTransform.position += new Vector3(1, 0, 0);

        return givenTransform.position;
    }






    bool TryJump()
    {
        bool didJump = true;
        // ...

        return didJump;
    }

    int SubtractNumbers(int a, int b)
    {
        transform.position += new Vector3(1, 0, 0);

        return a - b;
    }
}
