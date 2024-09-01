using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField] private GameObject gameplayUI;
    [SerializeField] private GameObject gameOver;
    [SerializeField] private GameObject shopUI;
    [SerializeField] private TextMeshProUGUI score;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            gameplayUI.SetActive(false);
            shopUI.SetActive(false);
            gameOver.SetActive(false);
        }

        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        GameManager.instance.playerRevive += ActiveGameplayUI;
        GameManager.instance.gameOver += GameOver;
        GameManager.instance.onScoreChange += AddScore;
    }

    public void OpenShop()
    {
        gameplayUI.SetActive(false);
        shopUI.SetActive(true);
        shopUI.GetComponent<Animator>().Play("ShopPanel_Open");
    }

    public void CloseShop()
    {
        shopUI.GetComponent<Animator>().Play("ShopPanel_Close");
    }

    public void ActiveGameplayUI()
    {
        gameplayUI.SetActive(true);
        shopUI.SetActive(false);
        gameOver.SetActive(false);
    }

    public void GameOver()
    {
        gameplayUI.SetActive(false);
        gameOver.SetActive(true);
    }

    public void AddScore()
    {
        score.text = $"Score: {GameManager.instance.Score}";
    }
}
