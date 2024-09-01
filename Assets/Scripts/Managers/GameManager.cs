using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int Score { get; set; }
    public int PlayerPenetration { get; set; }
    public float PlayerHealth { get; set; }
    public float PlayerRecovery { get; set; }
    public int ProjectileAmount { get; set; }
    public Vector2 LookDirection { get; set; }
    public Transform playerPosition;
    public float EnemyDifficulty { get; set; }

    public int Money { get; set; }

    public Action gameOver;
    public Action playerRevive;
    public Action onMoneyChange;
    public Action onScoreChange;

    private void Awake()
    {
        if (instance == this)
        {
            LookDirection = Vector2.right;
            Score = 0;
            EnemyDifficulty = 1.0f;
            Time.timeScale = 1.0f;
            ContinueGame();
        }

        else if (instance == null)
        {
            instance = this;
            LookDirection = Vector2.right;
            Score = 0;
            EnemyDifficulty = 1.0f;
            PlayerHealth = 10;
            PlayerRecovery = 0.2f;
            EnemyDifficulty = 1.0f;
            Time.timeScale = 1.0f;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        EnemyDifficulty += Time.deltaTime * 0.1f;
    }

    public void GameOver()
    {
        Money += Score;
        Time.timeScale = 0.0f;
        gameOver?.Invoke();
        onMoneyChange?.Invoke();
    }

    public void ContinueGame()
    {
        playerRevive?.Invoke();
        Time.timeScale = 1.0f;
        Money -= Score;
        onMoneyChange?.Invoke();
    }

    public void SubtractMoney(int amount)
    {
        Money -= amount;
        onMoneyChange?.Invoke();
    }

    public void AddScore(int score)
    {
        Score += score;
        onScoreChange?.Invoke();
    }
}
