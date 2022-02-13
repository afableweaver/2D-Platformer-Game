using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VoidColliderScript : MonoBehaviour
{
    private UnityEngine.SceneManagement.Scene currentLevel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null)
        {
            PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();
            playerController.HurtPlayer();
            playerController.HurtPlayer();
            playerController.HurtPlayer();
        }
    }

    private void Awake()
    {
        
    }
}
