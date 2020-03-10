using UnityEngine;

public class DataTypes : MonoBehaviour
{
    // Jede Zahl ohne Komma (-1, 1, 12876, ...)
    public int ganzzahl = 1;

    // Kommazahl. Muss mit '.' geschrieben werden, kein ','! Am Ende muss immer ein 'f' stehen.
    // (18976.1f, 0.00001f, 123.456, ...)
    public float kommazahl = 1.2098f;

    // Kann nur wahr oder falsch sein (true / false)
    public bool boolean = true;
}
