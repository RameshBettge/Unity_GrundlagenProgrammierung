using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMover_Simple : MonoBehaviour
{
    // Wir legen eine referenz zu einer Instanz von MovableBlock an
    // und weisen diese im Inspektor zu.
    public MovableBlock blockToMove;

    public float distanceToMove = 0;

    void Update()
    {
        // Wir greifen auf die Instanz von MovableBlock zu
        // und rufen eine Funktion davon aus.
        // Als Parameter übergeben wir unsere distanceToMove
        blockToMove.BeMoved(distanceToMove);
    }
}
