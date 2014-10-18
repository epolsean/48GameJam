using UnityEngine;
using System.Collections;

public class PlayerAnimationController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponentInChildren<Animation>().Play();
        GetComponentInChildren<Animation>()["OtherPlayerInflate"].speed = 0;
        GetComponentInChildren<Animation>()["OtherPlayerInflate"].time = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
