using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clipboard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(!pauseMenu.activeSelf);
        }
    }

    public GameObject pauseMenu;

    private void OnMouseUpAsButton()
    {
        pauseMenu.SetActive(true);
    }
}
