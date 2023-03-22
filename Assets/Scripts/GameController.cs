using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text[] buttonList;
    private string playerSide;
    

    public void SetGameControllerReferenceOnButtons()
    {
        for (int i = 0; i<buttonList.Length; i++)
        {
            buttonList[i].GetComponentInParent<GridSpace>().SetGameControllerReference(this);
            if (buttonList[0].text == playerSide && buttonList[1].text == playerSide && buttonList[2].text == playerSide)
            {

            }

        }
    }

    private void Awake()
    {
        SetGameControllerReferenceOnButtons();
        playerSide = "X";
    }
    public string GetPlayerSide()
    {
        return "playerSide";
        
    }
    public void EndTurn()
    {
        
    }
    void GameOver()
    {
        for (int i = 0; i < buttonList.Length; i++)
        {
            buttonList[i].GetComponentInParent<Button>().interactable = false;
        }
    }
    
}

