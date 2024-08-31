using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class RotateWeapon : MonoBehaviour
{
    [SerializeField] Transform player;
    public void RotateObject(InputAction.CallbackContext context)
    {
        float rads = Mathf.Atan2(GameManager.instance.LookDirection.y, GameManager.instance.LookDirection.x);
        float degrees = rads * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, 0, degrees);
    }
}
