using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicGunProjectile : MonoBehaviour
{
    Vector2 direction;
    [SerializeField] float bulletSpeed;
    [SerializeField] Rigidbody2D rb;
    private float damage;
    [SerializeField] float penetrate;

    private void Start()
    {
        penetrate += GameManager.instance.PlayerPenetration;
    }

    private void FixedUpdate()
    {
        rb.velocity = direction * bulletSpeed;
    }

    public void SetDirection(Vector2 direction)
    {
        this.direction = direction;
    }

    public void SetVariables(Vector2 direction, float damage)
    {
        this.direction = direction;
        this.damage = damage;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision detected with tag: " + collision.gameObject.tag);
        if(collision.CompareTag("Enemy"))
        {
            collision.GetComponent<EnemyHealth>().TakeDamage(damage);
            GameManager.instance.Score++;
            penetrate--;
            if(penetrate <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
