using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangulo : MonoBehaviour
{

    public int aSide;
    public int bSide;
    public int cSide;


    // Start is called before the first frame update
    void Start()
    {
        List<int> lados = new List<int>() { aSide, bSide, cSide };
        int total = 0;
        for (int i = 0; i < lados.Count; i++)
        {
            for (int j = 0; j < lados.Count; j++)
            {
                if (lados[i] > lados[j])
                {
                    total += 1;
                }
            }
        }


        if (total == 2)
        {
            Debug.Log("Seu triângulo é isósceles");
        }
        else if (total == 3)
        {
            Debug.Log("Seu triângulo é Escaleno");
        }
        else if (total == 0)
        {
            Debug.Log("Seu triângulo é Equilatero");
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
