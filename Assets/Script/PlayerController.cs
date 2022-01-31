using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    //public variables for access
    public float speed;         //player speed
    public bool crouch;         //crouch bool
    public float jump;          //player jump force value
    public float horizontal;    //player horizontal movement
    private float vertical;     //player vertical movement

    private Vector2 position;   //player position

    private Rigidbody2D rb2d;
    private BoxCollider2D boxcollider;
    public GroundCheck GroundStatus;
    public ScoreController scoreController;


    private void Awake()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        boxcollider = gameObject.GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        //assigning variables
        horizontal = Input.GetAxisRaw("Horizontal");
        crouch = Input.GetKey(KeyCode.LeftControl);
        vertical = Input.GetAxisRaw("Jump");

        PMAnimation(horizontal, vertical, crouch);
    }

    private void FixedUpdate()
    {   
        //CHARACTER MOVEMENT

        // player horizontal movement
        Vector2 position = transform.position;
        position.x += horizontal * speed * Time.deltaTime;
        transform.position = position;

        //player vertical movement
        if (vertical > 0 && GroundStatus.isGrounded == true)
        {
            rb2d.AddForce(new Vector2(0f, jump), ForceMode2D.Impulse);
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

        //player crouch and collider resize
        animator.SetBool("Crouching", crouch);
        Vector2 collscale = boxcollider.size;
        Vector2 colloffset = boxcollider.offset;
        if (crouch==true)
        {
            collscale = new Vector2(0.9480562f, 1.25814f);
            colloffset = new Vector2(-0.120859f, 0.5891516f);
        }
        else
        {
            collscale = new Vector2(0.63787f,2.02f);
            colloffset = new Vector2(0.02717397f, 0.9700818f);
        }
        boxcollider.size = collscale;
        boxcollider.offset = colloffset;

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


    public void PickUpKey()
    {
        scoreController.keyFound = true;
        scoreController.refreshUI();
    }

}
