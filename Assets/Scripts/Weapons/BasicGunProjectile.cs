using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicGunProjectile : MonoBehaviour
{
    private Vector2 direction;
    [SerializeField] float bulletSpeed;
    [SerializeField] Rigidbody2D rb;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.velocity = direction * bulletSpeed;
    }

    public void SetDirection(Vector2 direction)
    {
        this.direction = direction;
    }
}
