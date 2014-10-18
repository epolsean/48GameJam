using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

    public GameObject mainMenu;
    public GameObject credits;
    public GameObject settings;

	// Use this for initialization
	void Start () {
        mainMenu.SetActive(true);
        credits.SetActive(false);
        settings.SetActive(false);
	}

    public void Back () {
        mainMenu.SetActive(true);
        credits.SetActive(false);
        settings.SetActive(false);
    }

    public void Credits () {
        mainMenu.SetActive(false);
        credits.SetActive(true);
    }

    public void Play () {
        //Application.LoadLevel();
    }

    public void Quit () {
        Application.Quit();
    }

    public void Settings () {
        mainMenu.SetActive(false);
        settings.SetActive(true);
    }
}
