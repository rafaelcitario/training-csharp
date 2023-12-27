using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercicio01 : MonoBehaviour
{
    public int x;
    public int y;




    // Start is called before the first frame update
    void Start()
    {
        int soma = x + y;
        Debug.Log("A soma entre x e y é igual a: " + soma);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
