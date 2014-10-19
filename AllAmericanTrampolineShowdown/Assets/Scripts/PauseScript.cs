using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour{

    bool paused;
    public GameObject pauseMenu;
    public GameObject settings;

    void Start () {
        pauseMenu.SetActive(false);
        settings.SetActive(false);
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                pauseMenu.SetActive(false);
                settings.SetActive(false);
                paused = false;
            }
            else
            {
                pauseMenu.SetActive(true);
                settings.SetActive(false);
                paused = true;
            }
        }
    }

    public void Back () {
        pauseMenu.SetActive(true);
        settings.SetActive(false);
    }

    public void MainMenu () {
        Application.LoadLevel(0);
    }

    public void Resume () {
        pauseMenu.SetActive(false);
        paused = false;
    }

    public void Quit () {
        Application.Quit();
    }

    public void Settings () {
        pauseMenu.SetActive(false);
        settings.SetActive(true);
    }
}
