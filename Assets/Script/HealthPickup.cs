using System;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public float horiAmp, horiSpeed, vertAmp, vertSpeed;
    private Vector3 origTransform;

    private HealthBar healthBar;

    private void Start()
    {
        origTransform = transform.position;
        healthBar = gameObject.GetComponent<HealthBar>();
    }

    private void FixedUpdate()
    {
        transform.position = origTransform + new Vector3(Mathf.Sin(Time.time*horiSpeed) * horiAmp, Mathf.Sin(Time.time * vertSpeed) * vertAmp, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null)
        {
            PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();
            healthBar.PlayerHeals();
            Destroy(gameObject);
        }
    }
}
