using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject cutScene;
    public void StartGame()
    {
        cutScene.SetActive(true);
        cutScene.GetComponentInChildren<IntroAnimation>().StartCutscene();
        //SceneManager.LoadScene("Level");
    }
    public void LoadGame()
    {
        //Not done yet
    }
    public void OpenSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void OpenMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
