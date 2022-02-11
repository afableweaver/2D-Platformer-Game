using UnityEngine;
using UnityEngine.SceneManagement;

public class VoidColliderScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null)
        {
            SceneManager.LoadScene("TileMapTrial");
        }
    }
}
