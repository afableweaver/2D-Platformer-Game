using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public int health;
    public int numofhearts;
    
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public Animator[] hbAnimator;

    private void Update()
    {
        if (health > numofhearts)
        {
            health = numofhearts; //override for when health is greater than numofhearts - this is for when health powerups exist.
        }
        //setting ui to match health
        for (int i = 0; i < hearts.Length; i++)
        {
            //displays ui to match health
            if (i<health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            //displays ui to match numofhearts
            if (i<hearts.Length)
            {
                hearts[i].enabled = true;  //enables the heart 
            }
            else
            {
                hearts[i].enabled = false;  //disables the heart 
            }
        }
    }
    public void PlayerHurts()
    {
        health -= 1;
        hbAnimator[health].SetTrigger("Player_Hurts");
    }

    public void PlayerHeals()
    {
        if (health != numofhearts)
        {
            hbAnimator[health].SetTrigger("Player_Heals");
            health += 1;
        }
    }
}
