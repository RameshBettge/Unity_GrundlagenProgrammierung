using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    float speed = 0.1f;

    // Wir erstellen eine neue Farbe mit rot = 1, grün = 0, blau = 0.
    Color red = new Color(1, 0, 0);

    // Update is called once per frame
    void Update()
    {
        // Wir greifen auf die Position unseres Transforms zu. 
        // Wir setzen diese Position auf ihren eigenen Wert plus eine gewisse Distanz in x-Richtung.
        transform.position = transform.position + new Vector3(speed, 0, 0);

        // Wir greifen auf unseren BoxCollider zu und setzen darin einen bool namens 'isTrigger' auf true.
        GetComponent<BoxCollider>().isTrigger = true;

        // Wir greifen auf den MeshRenderer zu, dann auf dessen Material und dann wiederum auf die Farbe des Materials.
        // Wir setzen diese Farbe auf eine oben vordefinierte Farbe namens 'red'.
        GetComponent<MeshRenderer>().material.color = red;
    }
}
