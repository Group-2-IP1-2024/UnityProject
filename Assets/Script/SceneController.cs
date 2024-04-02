using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public string nextScene;
    public void SceneChanger()
    {
        // Unloads current scene and loads specified scene
        SceneManager.LoadScene(nextScene);
    }

    public void Quit()
    {
        // Logs quit button and exits game
        Debug.Log("You have exited the game");
        Application.Quit();
    }
}
