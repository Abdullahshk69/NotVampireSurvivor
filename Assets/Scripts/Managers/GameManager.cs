using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] TextMeshProUGUI score;

    public int Score {  get; set; }
    public int PlayerPenetration {  get; private set; }
    public int PlayerHealth {  get; private set; }
    public int PlayerRecovery { get; private set; }
    public int ProjectileAmount { get; private set; }
    public Vector2 LookDirection { get; set; }
    public Transform playerPosition;

    private void Start()
    {
        if(instance == null)
        {
            instance = this;
            LookDirection = Vector2.right;
            Score = 0;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        score.text = "Score: " + Score;
    }
}
