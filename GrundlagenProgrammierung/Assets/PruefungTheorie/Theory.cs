using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Theory : MonoBehaviour
{
    // ------ Variablen -----

    // Variablen sind Platzhalter
    // "Variablen" sind veränderbare Datenpakete

    // Eine Art von Variable ist die Ganzzahl z.B.: int meineZahl = 0;
    // Es gibt viele Arten von Variablen

    

    // Variable - kann selbt zugewiesene Daten oder einen Standardwert beinhalten 
    // und wird benutzt, übersichtlicher zu arbeiten und um Daten über mehrere Methoden/Klassen hinweg
    // beizubehalten


    // Variable
    // Wenn eine variable in eine Funktion ls Parameter übergeben wird,
    // dann verändert sich nur die neue variable innerhalb der Funktion.
    // Die ursprüngliche Variable verändert sich nicht.


    // können public oder private sein
    // Behälter, dessen Inhalt wir benutzen können
    // Name wird klein geschrieben
    // wichtige: int, float, string, Vector3, bool


    // --- Variablen Demonstration --- 
    int meineZahl = 0;

    private void Start()
    {
        // Erhöht meineZahl um 1
        IncreaseMeineZahl();
        // Wird 1 printen
        PrintMeineZahl();

        // Kopiert den Wert von meineZahl und erhöht nur die Kopie davon um 1
        IncreaseAnInt(meineZahl);
        // wird 0 printen
        PrintAnInt(meineZahl);
    }

    void IncreaseAnInt(int givenInt)
    {
        givenInt += 1;
    }

    void PrintAnInt(int givenInt)
    {
        print(givenInt);
    }

    void IncreaseMeineZahl()
    {
        meineZahl += 1;
    }

    void PrintMeineZahl()
    {
        print(meineZahl);
    }



    // ----- Referenzen -----

    // Eine Variable kopiert sich immer wieder, 
    // Eine Referenz ist wie eine Wegbeschreibung zu einem Objekt


    // Eine Referenz ist eine Art von Variable, 
    // transform.position = new Vector3(0,0,0);


    // "Referenzen" beziehen sich auf etwas. Sie sind eine Art link, die sich auf etwas beziehen. 
    // transform.ist eine Referenz, da sie sich auf die Transform in Unity beziehen.


    // Referenz: Bezug zu einem woanders festgelegten Objekt;
    // sobald dieses verändert wird, ändern sich auch die jeweiligen Referenzen

    // 'Wegbeschreibung'

    // Referenz = verweist auf ein Objekt (auf eine Instanz von einer Klasse)



    // ----- Funktionen -----

    // Eine Funktion führt immer die gleichen Befehle durch
    // Das Resultat von der Funktion kann dennoch variieren, 
    // basierend darauf, welche Parameter man hinein gibt


    //      "Funktionen" bearbeiten/verändern/erstellen Variablen.
    //      Eine Funktion kann andere Funktionen ausführen.
    //      Eine Funktion hat immer einen RückgabeTypen. 
    //      Wir können jeden von Variable oder Referenz zurück geben. Beispiele: Void, float, int, string, Transform, GameObject ...
    //      So werden Funktionen erstellt: 
    //      RückgabeTyp FunktionsName (ParameterTyp1 ParameterName1, ParameterTyp2 ParameterName2) 
    //      {
    //          // Code, der ausgeführt werden soll
    //          // Erstellt variable vom Typ RückgabeTyp mit Namen  meineVariable
    //            return meineVariable;
    //      }


    // Funktionen Namen beginnen mit einem Großbuchstaben
    // Funktionen beinhalten Code. Wenn eine Funktion aufgerufen wird, 
    // wird dieser Code ausgeführt.
    // Innerhalb von Funktionen können variablen verändert werden


    // Funktion - Benutzen Variablen, um bestimmte Operationen durchzuführen, 
    // zum Beispiel vergleichen, addieren oder multiplizieren


    // Funktion: Der ausführenden Teile in einer Klasse, besteht aus Ausgabetyp, Name, Parametertyp + Parametername


    // Funktion:
    //    Code wird in Funktion eingegeben, damit man ihn mehrmals benutzen kann und damit der Code besser geordnet ist
    //    z.B void MyFunction() {..}


    // Funktion = Event der ausgeführt / berechnet wird (z.B. void)
    // innerhalb einer Funktion können Berechnungen ausgeführt werden.
    // Funktionen werden ausgeführt.



    // ----- Klassen -----

    // Bestehen aus variablen und Funktionen und definieren die Eigenschaften und das Verhalten eines Objektes

    // Eine Klasse ist immer nur einmal da, kann aber unendlich viele Instanzen haben.

    // Scripte sind Dateien, in denen sich u.A. Klassen befinden können.
    // Klassen beinhalten Variablen, Referenzen und Funktionen.
    // Wichtig ist, dass der Name des Scripts und die der Klasse übereinstimmen.



    // Klasse: Ist innerhalb vom einem Script definiert. 
    // variablen, Referenzen und Funktionen kommen in die Klasse
    // Um von einer Klasse auf die Instanz einer anderen zuzugreifen, benötigen wir eine Referenz

    //  Möglichkeit Code zu zu unterteilen und zu ordnen
    //  Name muss mit Scriptnamen übereinstimmen : MonoBehaviour
}