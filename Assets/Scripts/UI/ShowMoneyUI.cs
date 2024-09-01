using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowMoneyUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI moneyTxt;

    private void Awake()
    {
        moneyTxt.text = $"{GameManager.instance.Money}";
    }

    public void BuyStuff()
    {
        moneyTxt.text = $"{GameManager.instance.Money}";
    }
}
