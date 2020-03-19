using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiranhaPlant : MonoBehaviour
{
    public float retractDistance = 2f;

    float upHeight;
    float downHeight;

    float targetHeight;

    bool isMovingUp = true;

    void Start()
    {
        upHeight = transform.position.y;
        downHeight = upHeight - retractDistance;

        targetHeight = downHeight;

        MovePosition();
    }

    void Update()
    {
        if (isMovingUp)
        {
            MoveUp();
        }
        if (isMovingUp == false)
        {
            MoveDown();
        }

        MovePosition();
    }

    void MoveUp()
    {
        targetHeight += 0.01f;

        bool hasReachedUpHeight = targetHeight > upHeight;

        if (hasReachedUpHeight)
        {
            isMovingUp = false;
        }
    }

    void MoveDown()
    {
        targetHeight -= 0.01f;
                                    
        bool hasReachedDownHeight = targetHeight < downHeight;

        if (hasReachedDownHeight)
        {
            isMovingUp = true;
        }
    }

    void MovePosition()
    {
        Vector3 targetPosition = new Vector3(transform.position.x, targetHeight, transform.position.z);

        transform.position = targetPosition;
    }
}
