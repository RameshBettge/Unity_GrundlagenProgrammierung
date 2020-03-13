using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMover : MonoBehaviour
{
    public MovableBlock blockToMove;
    public MovableBlock blockToMove2;

    public float distanceToMove = 0;

    void Update()
    {
        MoveBlock(blockToMove);
        MoveBlock(blockToMove2);
    }

    void MoveBlock(MovableBlock blockToMove)
    {
        if(blockToMove != null)
        {
            blockToMove.BeMoved(distanceToMove);
        }
    }
}
