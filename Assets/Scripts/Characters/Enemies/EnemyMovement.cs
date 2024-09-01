using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Transform playerPosition;
    [SerializeField] float moveSpeed;
    [SerializeField] SpriteRenderer sprite;
    [SerializeField] Rigidbody2D rb;

    private void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if (transform.position.x < playerPosition.position.x)
        {
            sprite.flipX = true;
        }
        else
        {
            sprite.flipX = false;
        }
    }

    private void FixedUpdate()
    {
        Vector2 direction = playerPosition.position - transform.position;

        rb.velocity = direction.normalized * moveSpeed;
    }
}
