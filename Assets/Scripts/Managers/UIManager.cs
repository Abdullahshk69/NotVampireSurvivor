using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameplayUI;
    [SerializeField] private GameObject checkpointUI;
    [SerializeField] private GameObject shopUI;

    private void Start()
    {
        gameplayUI.SetActive(true);
        checkpointUI.SetActive(false);
        shopUI.SetActive(false);
    }

    void EnterCheckpoint()
    {
        gameplayUI.SetActive(false);
        checkpointUI.SetActive(true);
    }

    void ExitCheckpoint()
    {
        gameplayUI.SetActive(true);
        checkpointUI.SetActive(false);
    }

    void ReachGoal()
    {
        gameplayUI.SetActive(false);
        checkpointUI.SetActive(true);
        Transform continueButton = checkpointUI.transform.Find("ContinueButton");
        continueButton.gameObject.SetActive(false);
    }
}
