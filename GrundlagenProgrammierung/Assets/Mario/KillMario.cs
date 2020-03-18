using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillMario : MonoBehaviour
{
    float killHeight = 0.1f;


    void OnCollisionEnter(Collision collision)
    {
        GameObject otherObject = collision.gameObject;
        MarioMovement marioMovement = otherObject.GetComponent<MarioMovement>();

        // if marioMovement was found
        if(marioMovement != null)
        {
            float ourHeight = transform.position.y;
            float marioHeight = otherObject.transform.position.y;

            float marioHeightAdvantage = marioHeight - ourHeight;

            if(marioHeightAdvantage > killHeight)
            {
                Destroy(gameObject);
            }
            if (marioHeightAdvantage < killHeight)
            {
                Destroy(otherObject);
            }
        }
    }
}
