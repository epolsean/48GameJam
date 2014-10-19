using UnityEngine;
using System.Collections;

public class BurgerHit : MonoBehaviour {

    public GameObject BounceController;
    public GameObject player1;
    public GameObject player2;

    float endTime = 0;

    // Use this for initialization
	void Start () {
        BounceController = GameObject.Find("FakeBounceController");
        if (GameObject.Find("Player01") != null)
        {
            player1 = GameObject.Find("Player01");
        }
        if (GameObject.Find("Player02") != null)
        {
            player2 = GameObject.Find("Player02");
        }
        if(GameObject.Find("EnemyAI") != null)
        {
            player2 = GameObject.Find("EnemyAI");
        }
	}

    void Update()
    {
        if(endTime <= Time.time && endTime != 0)
        {
            Application.LoadLevel(3);
        }
        print(endTime);
    }

    /*public void GoToEnd()
    {
        Application.LoadLevel(3);
    }
    public void ToEnd()
    {
        Invoke("GoToEnd", 3);
    }*/

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(this.gameObject.tag);
        Debug.Log(other.name);
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
            if (BounceController.GetComponent<FakeBounceSim>().PlayerBounceSpeed > BounceController.GetComponent<FakeBounceSim>().Player1MinHeight)
            {
                BounceController.GetComponent<FakeBounceSim>().PlayerBounceSpeed--;
            }
            BounceController.GetComponent<FakeBounceSim>().Player1MaxHeight--;
            //other.GetComponentInChildren<Animation>().Play();
            other.GetComponentInChildren<Animation>().animation["CharacterFatness"].time += 0.15f;
            if (other.GetComponentInChildren<Animation>().animation["CharacterFatness"].time >= 1)
            {
                //other.GetComponentInChildren<Animation>().animation["OtherPlayerInflate"].time = 1;
                endTime = Time.time + 3;
                BounceController.GetComponent<FakeBounceSim>().isPlayerFattist = true;
                BounceController.GetComponent<FakeBounceSim>().PlayerTrampoline.GetComponent<TestTramp>().AnimTop.SetActive(false);
                BounceController.GetComponent<FakeBounceSim>().PlayerTrampoline.GetComponent<TestTramp>().TareTop.SetActive(true);
                //Invoke("GoToEnd", 3);
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
                endTime = Time.time + 3;
                BounceController.GetComponent<FakeBounceSim>().isOtherFattist = true;
                BounceController.GetComponent<FakeBounceSim>().OtherTrampoline.GetComponent<TestTramp>().AnimTop.SetActive(false);
                BounceController.GetComponent<FakeBounceSim>().OtherTrampoline.GetComponent<TestTramp>().TareTop.SetActive(true);
                //Invoke("GoToEnd", 3);
            }
            print("Animation Time: " + other.GetComponentInChildren<Animation>().animation["CharacterFatness"].time);
            Destroy(this.gameObject);
        }
        if (other.name == "Pickup1(Clone)")
        {
            if (this.gameObject.tag == "Player1Bullet")
            {
                Debug.Log("player pickup 1");
                player1.GetComponentInChildren<FPBS>().hasFlameBurg = true;
            }
            else if (this.gameObject.tag == "Player2Bullet")
            {
                Debug.Log("AI pickup 1");
                player2.GetComponent<FPBS>().hasFlameBurg = true;
            }
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        else if (other.name == "Pickup2(Clone)")
        {
            if (this.gameObject.tag == "Player1Bullet")
            {
                Debug.Log("player pickup 2");
                player1.GetComponent<FPBS>().hasTripBurg = true;
            }
            else if (this.gameObject.tag == "Player2Bullet")
            {
                Debug.Log("AI pickup 2");
                player2.GetComponent<FPBS>().hasTripBurg = true;
            }
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        else if (other.name == "Pickup3(Clone)")
        {
            if (this.gameObject.tag == "Player1Bullet")
            {
                Debug.Log("player pickup 3");
            }
            else if (this.gameObject.tag == "Player2Bullet")
            {
                Debug.Log("AI pickup 3");
            }
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        else if (other.name == "Pickup4(Clone)")
        {
            if (this.gameObject.tag == "Player1Bullet")
            {
                Debug.Log("player pickup 4");
            }
            else if (this.gameObject.tag == "Player2Bullet")
            {
                Debug.Log("AI pickup 4");
            }
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
