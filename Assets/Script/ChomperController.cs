using UnityEngine;

public class ChomperController : MonoBehaviour
{
    public Animator animator;
    public static float speed =1f;

    private void Update()
    {
        ChomperAnimation();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null)
        {
            PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();
            playerController.KillPlayer();
        }
    }


    private void ChomperAnimation()
    {
        if (speed > 0)
        {
            animator.SetBool("Chomper_Walk", true);
        }
        else
        {
            animator.SetBool("Chomper_Walk", false);
        }
    }
}
