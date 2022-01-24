using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    //public variables for access
    public float speed;
    public bool crouch;
    public float jump;
    private Rigidbody2D rb2d;

    private void Awake()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Jump");
        bool crouch = Input.GetKey(KeyCode.LeftControl);
        MoveChar(horizontal, vertical);
        PMAnimation(horizontal, vertical, crouch);
    }

    private void MoveChar(float horizontal, float vertical)
    {
        // player horizontal movement
        Vector2 position = transform.position;
        position.x += horizontal * speed * Time.deltaTime;
        transform.position = position;

        //player vertical movement
        if (vertical>0)
        {
            rb2d.AddForce(new Vector2(0f, jump), ForceMode2D.Force) ;
        }
        else
        {

        }
    }    

    private void PMAnimation(float horizontal, float vertical, bool crouch)
    {
        //player walk etc
        animator.SetFloat("Speed", Mathf.Abs(horizontal));
        Vector3 scale = transform.localScale;
        if (horizontal < 0)
        {
            scale.x = -1f * Mathf.Abs(scale.x);
        }
        else if (horizontal > 0)
        {
            scale.x = Mathf.Abs(scale.x);
        }
        transform.localScale = scale;

        //player crouch
        animator.SetBool("Crouching", crouch);

        //player jump
        if (vertical > 0)
        {
            animator.SetBool("Jump", true);
        }
        else
        {
            animator.SetBool("Jump", false);
        }
    }

}
