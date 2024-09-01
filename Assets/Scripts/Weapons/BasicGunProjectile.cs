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
        GameManager.instance.playerRevive += DestroyBullet;
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
        if(collision.CompareTag("Enemy"))
        {
            collision.GetComponent<EnemyHealth>().TakeDamage(damage);
            penetrate--;
            if(penetrate <= 0)
            {
                DestroyBullet();
            }
        }
    }

    private void DestroyBullet()
    {
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        GameManager.instance.playerRevive -= DestroyBullet;
    }
}
