using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

enum PlayerState
{
    Idle,
    Move
};

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed;
    [SerializeField] private Animator anim;
    [SerializeField] private SpriteRenderer sprite;
    private Vector2 move;
    PlayerState state = PlayerState.Idle;

    private void Update()
    {
        anim.SetInteger("state", (int)state);
    }

    private void FixedUpdate()
    {
        rb.velocity = move;
    }

    public void PlayerMove(InputAction.CallbackContext context)
    {
        Vector3 lookDirection = context.ReadValue<Vector2>().normalized;
        move = lookDirection * moveSpeed;
        if (context.phase!=InputActionPhase.Canceled)
        {
            GameManager.instance.LookDirection = lookDirection;
            state = PlayerState.Move;
            if(lookDirection.x == 0f)
            {
                return;
            }

            if (lookDirection.x < 0f)
            {
                sprite.flipX = true;
            }
            else
            {
                sprite.flipX = false;
            }
        }
        else
        {
            state = PlayerState.Idle;
        }
    }
}
