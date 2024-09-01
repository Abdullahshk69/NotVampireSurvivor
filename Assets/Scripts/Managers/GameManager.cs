using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] TextMeshProUGUI score;
    [SerializeField] GameObject gameOverPanel;

    public int Score { get; set; }
    public int PlayerPenetration { get; set; }
    public float PlayerHealth { get; set; }
    public float PlayerRecovery { get; set; }
    public int ProjectileAmount { get; set; }
    public Vector2 LookDirection { get; set; }
    public Transform playerPosition;
    public float EnemyDifficulty { get; set; }

    public int Money { get; set; }

    private void Awake()
    {
        if (instance == this)
        {
            LookDirection = Vector2.right;
            Score = 0;
            EnemyDifficulty = 1.0f;
            DontDestroyOnLoad(gameObject);
        }

        else if (instance == null)
        {
            instance = this;
            LookDirection = Vector2.right;
            Score = 0;
            EnemyDifficulty = 1.0f;
            PlayerHealth = 10;
            PlayerRecovery = 0.2f;
        }

        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        score.text = "Score: " + Score;
        EnemyDifficulty += Time.deltaTime * 0.1f;
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Money += Score;
        Time.timeScale = 0.0f;
    }
}
