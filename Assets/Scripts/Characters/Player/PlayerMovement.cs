using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed;
    private Vector2 move;

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
        }
    }
}
