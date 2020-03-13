using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableBlock : MonoBehaviour
{
    public void BeMoved(float distance)
    {
        transform.position += new Vector3(1, 0, 0) * distance * Time.deltaTime;
    }
}