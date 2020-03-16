using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EinScript : MonoBehaviour
{
    //int zahl;
    //int sum = 1 + 2;

    //float kommaZahl = 0.1f;
    //float kommaZahlB;

    //string email = "@mail.com";
    //string anotherEmail;

    //Color defaultColor;
    //Color defaultRed = Color.red;

    Color MyCustomColor = new Color(1, 1, 0);

    public Transform cubeTransform;
    public Transform sphereTransform;

    public GameObject cubeGameObjec;

    private void Update()
    {
        MeshRenderer myRenderer = GetComponent<MeshRenderer>();

        if (myRenderer != null)
        {
            myRenderer.material.color = MyCustomColor;
        }

  

        cubeGameObjec.GetComponent<MeshRenderer>().material.color = MyCustomColor;

        MoveTransform(cubeTransform);
        MoveTransform(sphereTransform);


        Vector3 startVector = new Vector3(0, 0, 0);
        Vector3 neuerVector = ChangeVector(startVector);

    }

    Vector3 ChangeVector(Vector3 givenVector)
    {
        givenVector += new Vector3(1, 0, 0);

        return givenVector;
    }






    void MoveTransform(Transform givenTransform)
    {
        givenTransform.position = givenTransform.position + new Vector3(0, 1, 0) * 0.01f;
    }
}
