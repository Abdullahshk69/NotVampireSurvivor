using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int PlayerPenetration {  get; private set; }
    public int PlayerHealth {  get; private set; }
    public int PlayerRecovery { get; private set; }
    public int ProjectileAmount { get; private set; }
    public Vector2 LookDirection { get; set; }

    private void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
