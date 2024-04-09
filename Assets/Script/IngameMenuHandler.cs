using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IngameMenuHandler : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject pauseMenu;
    public GameObject menu;
    public GameObject options;

    public void TogglePause()
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);
    }

    public void Exit()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void switchoptions()
    {
        options.SetActive(!options.activeSelf);
        menu.SetActive(!menu.activeSelf);
    }
}
