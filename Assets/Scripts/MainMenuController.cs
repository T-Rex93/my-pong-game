using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Scenes/Game");
    }

    public void OpenAuthor()
    {
        Debug.Log("Created by Me");
    }

    public void ExitGame()
    {
        SceneManager.LoadScene("Scenes/MainMenu");
    }

    public void OpenCredits()
    {
        SceneManager.LoadScene("Scenes/Credits");
    }

    public void ExitCredits()
    {
        SceneManager.LoadScene("Scenes/MainMenu");
    }
}