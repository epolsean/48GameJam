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
            BounceController.GetComponent<FakeBounceSim>().OtherPlayer.audio.Play();
            //BounceController.GetComponent<FakeBounceSim>().PlayerBounceSpeed++;
            /*BounceController.GetComponent<FakeBounceSim>().PlayerBounceSpeed--;
            other.GetComponentInChildren<Animation>().animation["OtherPlayerInflate"].time += 0.15f;
            if(other.GetComponentInChildren<Animation>().animation["OtherPlayerInflate"].time >= 0.6)
            {
                other.GetComponentInChildren<Animation>().animation["OtherPlayerInflate"].time = 1;
            }
            Destroy(this.gameObject);*/
            BounceController.GetComponent<FakeBounceSim>().PlayerBounceSpeed--;
            //other.GetComponentInChildren<Animation>().Play();
            other.GetComponentInChildren<Animation>().animation["OtherPlayerInflate"].time += 0.15f;
            if (other.GetComponentInChildren<Animation>().animation["OtherPlayerInflate"].time >= 0.6)
            {
                other.GetComponentInChildren<Animation>().animation["OtherPlayerInflate"].time = 1;
                BounceController.GetComponent<FakeBounceSim>().isPlayerFattist = true;
            }
            //print("Animation Time: " + other.GetComponentInChildren<Animation>().animation["OtherPlayerInflate"].time);
            Destroy(this.gameObject);
        }
        else if(other.tag == "Player02")
        {
            BounceController.GetComponent<FakeBounceSim>().Player.audio.Play();
            BounceController.GetComponent<FakeBounceSim>().OtherPlayerBounceSpeed--;
            //other.GetComponentInChildren<Animation>().Play();
            other.GetComponentInChildren<Animation>().animation["OtherPlayerInflate"].time += 0.15f;
            if (other.GetComponentInChildren<Animation>().animation["OtherPlayerInflate"].time >= 0.6)
            {
                other.GetComponentInChildren<Animation>().animation["OtherPlayerInflate"].time = 1;
                BounceController.GetComponent<FakeBounceSim>().isOtherFattist = true;
            }
            print("Animation Time: " + other.GetComponentInChildren<Animation>().animation["OtherPlayerInflate"].time);
            Destroy(this.gameObject);
        }
    }
}
