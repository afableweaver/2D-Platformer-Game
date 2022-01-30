using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool isGrounded;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded = true;
        Debug.Log("Is grounded");
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded = false;
        Debug.Log("FLYING"+collision.gameObject.name);
    }
}
