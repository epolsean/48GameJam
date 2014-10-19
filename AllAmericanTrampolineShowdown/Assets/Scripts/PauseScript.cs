using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour{

    bool paused;
    public GameObject pauseMenu;

    void Start () {
        pauseMenu.SetActive(false);
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                pauseMenu.SetActive(false);
                paused = false;
                Time.timeScale = 1;
            }
            else
            {
                pauseMenu.SetActive(true);
                paused = true;
                Time.timeScale = 0;
            }
        }
    }

    public void Back () {
        pauseMenu.SetActive(true);
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
}
