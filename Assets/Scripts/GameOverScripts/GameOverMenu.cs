using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void GoToMenu ()
    {
        SceneManager.LoadScene("MainMenu_Scene");
    }
    public void GoToGameplay ()
    {
        SceneManager.LoadScene("Gameplay_Scene");
    }
    public void QuitGame ()
    {
        Application.Quit();
    }
}
