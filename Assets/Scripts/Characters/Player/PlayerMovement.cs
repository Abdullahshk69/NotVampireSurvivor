using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed;

    public void PlayerMove(InputAction.CallbackContext context)
    {
        Vector3 move = context.ReadValue<Vector2>().normalized;
        transform.position += move * moveSpeed;
        if (context.phase!=InputActionPhase.Canceled)
        {
            GameManager.instance.LookDirection = move;
        }
    }
}
