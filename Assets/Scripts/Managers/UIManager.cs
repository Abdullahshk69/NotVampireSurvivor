using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameplayUI;
    [SerializeField] private GameObject shopUI;

    private void Start()
    {
        gameplayUI.SetActive(false);
        shopUI.SetActive(false);
    }

    public void OpenShop()
    {
        gameplayUI.SetActive(false);
        shopUI.SetActive(true);
    }

    public void CloseShop()
    {
        shopUI.SetActive(false);
    }

    public void ActiveGameplayUI()
    {
        gameplayUI.SetActive(true);
        shopUI.SetActive(false);
    }
}
