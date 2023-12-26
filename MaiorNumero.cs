using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class MaiorNumero : MonoBehaviour
{
    public int numb_1;
    public int numb_2;
    public int numb_3;
    int numb;

    // Start is called before the first frame update
    void Start()
    {
        List<int> numbs = new List<int>(){
            numb_1,
            numb_2,
            numb_3
        };

        int acc;

        for (int i = 0; i < numbs.Count; i++)
        {
            acc = numbs[i];
            numb = acc;
            for (int j = 1; j < numbs.Count; j++)
            {

                if (numbs[j] - acc > 0)
                {
                    numb = numbs[j];
                }
            }
            break;
        }
#pragma warning restore CS0162 // Unreachable code detected
        Debug.Log("O Maior valor é: " + numb);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
