using UnityEngine;
using System.Collections;

public class PlayerAnimationControllerV2 : MonoBehaviour {

    public Animator AnimObj;
    // Use this for initialization
    void Start()
    {
        GetComponentInChildren<Animation>().Play();
        GetComponentInChildren<Animation>()["CharacterFatness"].speed = 0;
        GetComponentInChildren<Animation>()["CharacterFatness"].time = 0;
        AnimObj = GameObject.Find("Player01").GetComponentInChildren<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
