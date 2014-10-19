using UnityEngine;
using System.Collections;

public class BurgerHitV2 : MonoBehaviour {

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
            if (BounceController.GetComponent<FakeBounceSim>().PlayerBounceSpeed > BounceController.GetComponent<FakeBounceSim>().Player1MinHeight)
            {
                BounceController.GetComponent<FakeBounceSim>().PlayerBounceSpeed--;
            }
            BounceController.GetComponent<FakeBounceSim>().Player1MaxHeight--;
            //other.GetComponentInChildren<Animation>().Play();
            other.GetComponentInChildren<Animation>().animation["CharacterFatness"].time += 0.15f;
            if (other.GetComponentInChildren<Animation>().animation["CharacterFatness"].time >= 1)
            {
                //other.GetComponentInChildren<Animation>().animation["CharacterFatness"].time = 1;
                BounceController.GetComponent<FakeBounceSim>().isPlayerFattist = true;
                BounceController.GetComponent<FakeBounceSim>().PlayerTrampoline.GetComponent<TestTramp>().AnimTop.SetActive(false);
                BounceController.GetComponent<FakeBounceSim>().PlayerTrampoline.GetComponent<TestTramp>().TareTop.SetActive(true);
            }
            //print("Animation Time: " + other.GetComponentInChildren<Animation>().animation["OtherPlayerInflate"].time);
            Destroy(this.gameObject);
        }
        if(other.tag == "Player02")
        {
            BounceController.GetComponent<FakeBounceSim>().Player.audio.Play();
            BounceController.GetComponent<FakeBounceSim>().OtherPlayerBounceSpeed--;
            //other.GetComponentInChildren<Animation>().Play();
            other.GetComponentInChildren<Animation>().animation["CharacterFatness"].time += 0.15f;
            if (other.GetComponentInChildren<Animation>().animation["CharacterFatness"].time >= 1)
            {
                //other.GetComponentInChildren<Animation>().animation["CharacterFatness"].time = 1;
                BounceController.GetComponent<FakeBounceSim>().isOtherFattist = true;
                BounceController.GetComponent<FakeBounceSim>().OtherTrampoline.GetComponent<TestTramp>().AnimTop.SetActive(false);
                BounceController.GetComponent<FakeBounceSim>().OtherTrampoline.GetComponent<TestTramp>().TareTop.SetActive(true);
            }
            print("Animation Time: " + other.GetComponentInChildren<Animation>().animation["CharacterFatness"].time);
            Destroy(this.gameObject);
        }
        if (other.tag == "pickup")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
