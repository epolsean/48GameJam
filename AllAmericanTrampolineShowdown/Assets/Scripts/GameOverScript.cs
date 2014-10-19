using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

    public GameObject mainMenu;
    public GameObject quit;

    public void Menu () {
        Application.LoadLevel("Menu");
    }

    public void Quit () {
        Application.Quit();
    }

}
