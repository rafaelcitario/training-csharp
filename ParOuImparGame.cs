using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class ParOuImparGame : MonoBehaviour
{
    public string namePlayerOne;
    public string namePlayerTwo;

    public int handPlayerOne;
    public int handPlayerTwo;

    public bool playerOneEven;

    void Start()
    {

        int sumHands = handPlayerOne + handPlayerTwo;
        if (playerOneEven)
        {
            if (sumHands % 2 == 0)
            {
                Debug.Log(sumHands + " é par, portanto, player " + namePlayerOne + " venceu!");
            }
            else
            {
                Debug.Log(sumHands + " é impar, portanto, player " + namePlayerTwo + " venceu!");
            }
        }
        else
        {
            if (sumHands % 2 == 0)
            {
                Debug.Log(sumHands + " é impar, portanto, player " + namePlayerTwo + " venceu!");
            }
            else
            {
                Debug.Log(sumHands + " é par, portanto, player " + namePlayerOne + " venceu!");
            }
        }



    }
    void Update()
    {

    }
}