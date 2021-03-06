using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    
    public void PlayGame()
    {
        Debug.Log("Playgame was pressed.");
        SceneManager.LoadScene("Game");

    }

    public void PlayGameAI()
    {
        Debug.Log("PlaygameAI was pressed.");
        SceneManager.LoadScene("GameAI");
    }

    public void PlayMenu()
    {
        Debug.Log("Return To Menu was pressed.");
        SceneManager.LoadScene("MainMenu");
    }
}
