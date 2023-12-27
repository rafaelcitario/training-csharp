using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstruturaDeDecisao01 : MonoBehaviour
{

    public string personageName;
    public int personageAge;

    // Start is called before the first frame update
    void Start()
    {
        string message = "Olá, ";
        Debug.Log(message + personageName + ", você esta com " + personageAge + " de idade?");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
