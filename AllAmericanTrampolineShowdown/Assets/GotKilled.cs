using UnityEngine;
using System.Collections;

public class GotKilled : MonoBehaviour {

    public static bool DaEnd = false; 
    // Use this for initialization
	void Start () {
        DaEnd = false; 
	}
	
	// Update is called once per frame
	void Update () {
	    if(DaEnd)
        {
            Invoke("End", 3);
        }
	}

    void End()
    {
        Application.LoadLevel(3);
    }
}
