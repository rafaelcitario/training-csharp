using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsVogalOrNot : MonoBehaviour
{
    public string letter;

    // Start is called before the first frame update
    void Start()
    {
        List<string> letras = new List<string>() { "a", "e", "i", "o", "u", };
        foreach (string letra in letras)
        {
            if (!letter.Equals(letra))
            {
                Debug.Log(letter + " é uma consoante!");
                break;
            }
            Debug.Log(letter + " é uma vogal!");
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {


    }
}
