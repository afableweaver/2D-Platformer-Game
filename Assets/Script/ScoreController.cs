using UnityEngine;
using TMPro;
using System;

public class ScoreController : MonoBehaviour
{
    private TextMeshProUGUI displayText;
    private LevelController levelController;
    public bool levelPass = false;

    private void Awake()
    {
        displayText = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        RefreshUI(); 
    }

    public void RefreshUI()
    {
        if (levelPass == true)
        {
            displayText.text = "Key found. Get to the Portal.";
        }
        else
        {
            displayText.text = "Find the Key.";
        }
    } 
}
