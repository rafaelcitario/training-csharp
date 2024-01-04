using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

class Jokenpo : MonoBehaviour
{

    public InputField playerOneChoiceInput;
    public InputField PlayerName;
    public Text playerTwoChoiceText;
    public Text winnerText;

    public void PlayButton()
    {
        VerifyInputText();
    }

    public void MatchPlayersChoice()
    {
        List<string> choices = new() { "Pedra", "Papel", "Tesoura" };
        string choiceRange = choices[Random.Range(0, choices.Count)];
        playerTwoChoiceText.text = choiceRange;


        if (playerTwoChoiceText.text.Equals(choices[0])) // pedra
        {

            if (playerOneChoiceInput.text.Equals("Papel"))
            {
                winnerText.text = PlayerName.text + " venceu!";
            }
            else if (playerOneChoiceInput.text.Equals("Pedra"))
            {
                winnerText.text = "Empate";
            }
            else
            {
                winnerText.text = "Computador venceu! ";
            }
        }
        else if (playerTwoChoiceText.text.Equals(choices[1])) // papel
        {
            if (playerOneChoiceInput.text.Equals("Papel"))
            {
                winnerText.text = "Empate";
            }
            else if (playerOneChoiceInput.text.Equals("Pedra"))
            {
                winnerText.text = "Computador venceu! ";
            }
            else
            {
                winnerText.text = PlayerName.text + " venceu!";
            }
        }
        else if (playerTwoChoiceText.text.Equals(choices[2])) // tesoura
        {
            if (playerOneChoiceInput.text.Equals("Papel"))
            {
                winnerText.text = "Computador venceu! ";
            }
            else if (playerOneChoiceInput.text.Equals("Pedra"))
            {
                winnerText.text = PlayerName.text + " venceu!";
            }
            else
            {
                winnerText.text = "Empate";
            }
        }
    }
    void VerifyInputText()
    {
        playerOneChoiceInput.text = playerOneChoiceInput.text.FirstCharacterToUpper();

        if (playerOneChoiceInput.text.Equals("Pedra") || playerOneChoiceInput.text.Equals("Papel") || playerOneChoiceInput.text.Equals("Tesoura"))
        {
            MatchPlayersChoice();
        }
        else
        {
            playerTwoChoiceText.text = "";
            winnerText.text = "OPIÇÕES INVALIDAS!\nESCOLHE UMA DAS OPIÇÕES:\n1. Pedra\n2. Papel\n3. Tesoura";
        }
    }
}


