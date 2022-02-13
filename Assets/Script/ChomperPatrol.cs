using UnityEngine;

public class ChomperPatrol : MonoBehaviour
{
    private bool movingRight = true;
    public Transform GroundDetection;
    private float speed;
    private float landSkip; //1 instance skipped for when enemy lands on platform

    private void Update()
    {
        speed = ChomperController.speed;        //assigning updated value for speed every frame

        transform.Translate( speed * Time.deltaTime * Vector2.right); //enemy movement


        RaycastHit2D groundInfo = Physics2D.Raycast(GroundDetection.position, Vector2.down, 2f); //groundinfo ray
        Debug.DrawRay(GroundDetection.position, Vector2.down, Color.green);

        if (groundInfo.collider == false)
        {
            //Debug.Log("GroundRay is false");
            FlipEnemy();
        }
        
        if (movingRight == true)
        {
            RaycastHit2D wallInfo = Physics2D.Raycast(GroundDetection.position, Vector2.right, 1f); //wallinfo ray
            Debug.DrawRay(GroundDetection.position, Vector2.right, Color.green);
            if (wallInfo.collider == true && wallInfo.collider.GetComponent<PlayerController>() == null)
            {
                //Debug.Log("WallRay is right");
                FlipEnemy();
            }
        }
        else
        {
            RaycastHit2D wallInfo = Physics2D.Raycast(GroundDetection.position, Vector2.left, 1f); //wallinfo ray
            Debug.DrawRay(GroundDetection.position, Vector2.left, Color.green);
            if (wallInfo.collider == true && wallInfo.collider.GetComponent<PlayerController>() == null)
            {
                //Debug.Log("WallRay is left");
                FlipEnemy();
            }
        }

        
    }

    public void FlipEnemy()
    {
        if (landSkip>0)
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
        else { landSkip += 1; }
    }
}

