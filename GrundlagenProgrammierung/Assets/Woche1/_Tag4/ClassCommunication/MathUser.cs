using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathUser : MonoBehaviour
{
    void Start()
    {
        // Wir holen uns eine Referenz zu einer Instanz von MyMath,
        // welches auf dem selben Objekt liegt, wie dieses Script.
        MyMath myMath = GetComponent<MyMath>();

        // Wir rufen die Function 'Add' auf, die zu unserer MyMath-Klasse gehört.
        // Den Wert, den diese Funktion zurück gibt, speichern wir in einer Variable namens sum.
        float sum = myMath.Add(1, 2);

        // Wir geben das Ergebnis in der Konsole aus.
        print(sum);
    }
}
