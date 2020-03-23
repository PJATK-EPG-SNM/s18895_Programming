using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    void Start()
    {
        //jakies tam dzialanie na liczbach calkowitych
        int a = 10, b = 6, c;
        c = a + b;
        Debug.Log(a+" + "+b+" = "+c);

        //jakies inne dzialanie tym razem na liczbach zmiennoprzecinkowych
        float liczbaA = 2.5f, liczbaB = 4f, liczbaC;
        liczbaC = liczbaB / liczbaA;
        Debug.Log(liczbaB + " / " + liczbaA + " = " + liczbaC);

        //jakies napisy z boolenem
        bool logicznaA = true;
        Debug.Log("To jest prawda: "+logicznaA);
        bool logicznaB = false;
        Debug.Log("To jest falsz: " + logicznaB);

        //jakis zadeklarowany napis
        string napis = "Niedzwiedzie sa super.";
        Debug.Log(napis);

        //jakies operacje logiczne
        bool czyJestRownaA = c == liczbaC;
        Debug.Log("Czy " + c + " jest rowne " + liczbaC + "? "+ czyJestRownaA);
        bool czyJestRownaB = c != liczbaC;
        Debug.Log("Czy " + c + " nie jest rowne " + liczbaC + "? " + czyJestRownaB);
        bool czyJestRownaC = c >= liczbaC;
        Debug.Log("Czy " + c + " jest wieksze lub rowne " + liczbaC + "? " + czyJestRownaC);

        //jakies warunki
        int zdrowie=100;
        int cios = 10;
        zdrowie -= cios;
        bool tak = true;
        if(zdrowie<=0 && tak == true)
        {
            Debug.Log("Nie zyjesz. Postaraj sie nastepnym razem nie umierac.");
        }
        else
        {
            Debug.Log("Oj, dostales z mlotka! Masz teraz "+zdrowie+" punktow zycia!");
        }
    }
    void Update()
    {
        
    }
}
