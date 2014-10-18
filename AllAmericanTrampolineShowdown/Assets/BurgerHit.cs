using UnityEngine;
using System.Collections;

public class BurgerHit : MonoBehaviour {

    public GameObject BounceController;
    // Use this for initialization
	void Start () {
        BounceController = GameObject.Find("FakeBounceController");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            print("player is hit!");
            //BounceController.GetComponent<FakeBounceSim>().PlayerBounceSpeed++;
            Destroy(this.gameObject);
        }
        else if(other.tag == "Player02")
        {
            BounceController.GetComponent<FakeBounceSim>().OtherPlayerBounceSpeed++;
            //other.GetComponentInChildren<Animation>().Play();
            other.GetComponentInChildren<Animation>().animation["OtherPlayerInflate"].time += 0.15f;
            Destroy(this.gameObject);
        }
    }
}
