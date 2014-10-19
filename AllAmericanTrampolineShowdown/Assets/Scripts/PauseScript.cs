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
                Time.timeScale = 1;
            }
            else
            {
                pauseMenu.SetActive(true);
                settings.SetActive(false);
                paused = true;
                Time.timeScale = 0;
            }
        }
    }

    public void Back () {
        pauseMenu.SetActive(true);
        settings.SetActive(false);
    }

    public void MainMenu () {
        Application.LoadLevel(0);
        Time.timeScale = 1;
    }

    public void Resume () {
        pauseMenu.SetActive(false);
        paused = false;
        Time.timeScale = 1;
    }

    public void Quit () {
        Application.Quit();
    }

    public void Settings () {
        pauseMenu.SetActive(false);
        settings.SetActive(true);
    }
}
