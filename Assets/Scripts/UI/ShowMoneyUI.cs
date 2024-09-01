using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowMoneyUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI moneyTxt;

    private void Start()
    {
        GameManager.instance.onMoneyChange += ShowMoney;
    }

    private void OnEnable()
    {
        Debug.Log("Enabled");
        GameManager.instance.onMoneyChange += ShowMoney;
    }

    private void OnDisable()
    {
        Debug.Log("Disabled");
        GameManager.instance.onMoneyChange -= ShowMoney;
    }

    private void Awake()
    {
        moneyTxt.text = $"{GameManager.instance.Money}";
    }

    public void ShowMoney()
    {
        moneyTxt.text = $"{GameManager.instance.Money}";
    }
}
