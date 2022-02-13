using UnityEngine;
using TMPro;
using System;

public class ScoreController : MonoBehaviour
{
    public int[] levelPassCondition;
    public int keyScore;
    private TextMeshProUGUI displayText;
    private LevelController levelController;
    public bool levelPass = false;
    // private int gameScore = 0;
    // public int increment;

    private void Awake()
    {
        displayText = GetComponent<TextMeshProUGUI>();

        //entering Level pass condition - number of keys
        //levelPassCondition[0] = 1;
        //levelPassCondition[1] = 1;
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

    public void CheckLevelPass()
    {
        if (keyScore==levelPassCondition[levelController.currLevelCount])
        {
            levelPass = true;
        }
    }
}
