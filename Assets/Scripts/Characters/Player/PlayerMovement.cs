using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed;
    Vector2 touchPos = Vector2.zero;
    Vector2 move;

    private void Update()
    {
        //if(Input.touchCount > 0)
        //{
        //    Debug.Log("Touch Deteced");
        //    touchPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        //}
        //transform.position = Vector2.MoveTowards(transform.position, touchPos, 1.0f);
    }

    private void FixedUpdate()
    {
        //rb.velocity = move;
    }

    public void PlayerMove(InputAction.CallbackContext context)
    {
        transform.position += (Vector3)context.ReadValue<Vector2>().normalized * moveSpeed;
    }
}
