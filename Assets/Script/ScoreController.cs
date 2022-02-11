using UnityEngine;
using TMPro;
using System;

public class ScoreController : MonoBehaviour
{
    private TextMeshProUGUI displayText;
    public bool keyFound = false;
    // private int gameScore = 0;
    // public int increment;

    private void Awake()
    {
        displayText = GetComponent<TextMeshProUGUI>();   
    }

    private void Start()
    {
        refreshUI();    
    }

    /*public void IncreaseScore (int increment)
    {
        gameScore += increment;
        refreshUI();
    } */

    public void refreshUI()
    {
        if (keyFound == true)
        {
            displayText.text = "Key found. Get to the Portal.";
        }
        else
        {
            displayText.text = "Find the Key.";
        }
    } 
}
