using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[System.Serializable]
public abstract class AbstractUpgrade : MonoBehaviour
{
    [SerializeField] protected int upgradeCost;
    [SerializeField] protected float increaseStat;
    [SerializeField] protected TextMeshProUGUI upgradeCostTxt;

    protected void OnStart()
    {
        upgradeCostTxt.text = $"{upgradeCost}";
    }

    public void PurchaseUpgrade()
    {
        if(GameManager.instance.Money < upgradeCost)
        {
            Debug.Log("Low on money BOOO");
            return;
        }

        GameManager.instance.SubtractMoney(upgradeCost);
        ApplyUpgrade();
    }

    virtual protected void ApplyUpgrade()
    {

    }
}
