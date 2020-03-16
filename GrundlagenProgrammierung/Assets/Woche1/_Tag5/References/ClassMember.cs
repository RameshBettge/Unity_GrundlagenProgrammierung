using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassMember : MonoBehaviour
{
    public int myInt;
    public int meinUebergebenerInt;

    void Update()
    {
        MakeMyIntBigger();
        ChangeNumber(meinUebergebenerInt);
    }

    void MakeMyIntBigger()
    {
        myInt += 1;
    }

    void ChangeNumber(int givenNumber)
    {
        givenNumber += 1;
    }
}
