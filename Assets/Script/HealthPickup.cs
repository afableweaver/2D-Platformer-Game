using System;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public float horiAmp, horiSpeed, vertAmp, vertSpeed;
    private Vector3 origTransform;

    public HealthBar healthBar;

    private void Start()
    {
        origTransform = transform.position;
    }

    private void FixedUpdate()
    {
        transform.position = origTransform + new Vector3(Mathf.Sin(Time.time*horiSpeed) * horiAmp, Mathf.Sin(Time.time * vertSpeed) * vertAmp, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null)
        {
            healthBar.PlayerHeals();
            Destroy(gameObject);
        }
    }
}
