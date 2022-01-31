using UnityEngine;
using UnityEngine.SceneManagement;

public class VoidColliderScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("TileMapTrial");
    }
}
