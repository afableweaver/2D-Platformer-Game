using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private LevelController levelController;
    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.gameObject.GetComponent<PlayerController>() != null)
        {
            //Debug.Log("GameComplete");
            SceneManager.LoadScene((SceneManager.GetActiveScene()).buildIndex + 1);
            //levelController.NextLevel();
        }
    }

}
