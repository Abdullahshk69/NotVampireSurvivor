using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMainGameScene : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("MainGame");
    }
}
