using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiederholung : MonoBehaviour
{
    // Typ Name = Wert;
    // Typ Name;

    public int publicInt = 1;

    int myNumber = 2;
    int defaultNumber;

    float myFloat = 10.12f;

    string myName = "Steven";

    public Transform anderesTransform;

    public GameObject unserCube;

    MeshRenderer andererRenderer;



    Color myColor = new Color(1, 1, 1);

    float speed = 0.1f;

   

    void Start()
    {
        andererRenderer = unserCube.GetComponent<MeshRenderer>();
        andererRenderer.material.color = new Color(0, 0, 1);


        Transform anderesTransform = unserCube.transform;
        anderesTransform.position = new Vector3(0, 0, 0);

        BoxCollider andererCollider = unserCube.GetComponent<BoxCollider>();
        AssignRandomColor randomColorAssigner = unserCube.GetComponent<AssignRandomColor>();
        PositionColor myPositionColor = unserCube.GetComponent<PositionColor>();


        PublicColor meineColor = unserCube.GetComponent<PublicColor>();
        meineColor.myColor = new Color(1, 0, 0);


        int newDoubledInt = DoubleGivenInt(2);

        print(newDoubledInt);


    }



    int DoubleGivenInt(int givenInt)
    {
        int doubledInt = givenInt * 2;

        return doubledInt;
    }

    private void Update()
    {
        publicInt += 1;

        Move();
    }

    void Move()
    {
        Vector3 moveVector = new Vector3(1, 0, 0);
        transform.position = transform.position + moveVector * speed;
    }


    int AddNumbers(int a, int b)
    {
        int sum = a + b;

        return sum;
    }

    int MultiplyNumbers(int a, int b, int c)
    {
        int ergebnis = a * b * c;

        return ergebnis;
    }

    // Rückgabetyp EinName Parameter(typ ParameterName)
    void MoveTransform(Transform givenTransform)
    {
        givenTransform.position += new Vector3(1, 0, 0);
    }
}
