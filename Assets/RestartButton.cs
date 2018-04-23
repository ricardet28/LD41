using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour {

    public string mainScene = "MainMenu";

    public void RestartGame()
    {
        GameManager.instance.RestartGameLoop();
    }

    public void BackToMenu()
    {
        GameManager.instance.PauseGO.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
