using UnityEngine;
using System.Collections;

public class FakeBounceSim : MonoBehaviour {

    public GameObject Player;
    public GameObject OtherPlayer;
    public int PlayerBounceSpeed = 14;
    public int OtherPlayerBounceSpeed = 14;
    public bool isPlayerFattist = false;
    public bool isOtherFattist = false;
    public bool canPlayMusic = true; 

    public GameObject fallSoundController; 

    public GameObject PlayerTrampoline;
    public GameObject OtherTrampoline; 


    // Use this for initialization
	void Start () {
        fallSoundController = GameObject.Find("LosingSoundController");
	}
	
	// Update is called once per frame
	void Update () {
	    if(Player.transform.position.y <= 1.5)
        {
            print("Player UP");
            //Player.GetComponent<CharacterController>().velocity.Equals(Vector3.up * BounceSpeed);
            if (!isPlayerFattist)
            {
                PlayerTrampoline.GetComponent<TestTramp>().TrampAnim.SetBool("CanBounce", true);
                Player.rigidbody.velocity = transform.TransformDirection(Vector3.up * PlayerBounceSpeed);
                PlayerTrampoline.audio.Play();
            }
            else
            {
                //Player.GetComponent<Collider>().enabled = false;
                if (canPlayMusic)
                {
                    canPlayMusic = false;
                    fallSoundController.audio.Play();
                }
            }
        }
        if(OtherPlayer.transform.position.y <= 1.5)
        {
            print("Other Player UP");
            //OtherPlayer.GetComponent<CharacterController>().velocity.Equals(Vector3.up * BounceSpeed);
            if (!isOtherFattist)
            {
                OtherTrampoline.GetComponent<TestTramp>().TrampAnim.SetBool("CanBounce", true);
                OtherPlayer.rigidbody.velocity = transform.TransformDirection(Vector3.up * OtherPlayerBounceSpeed);
                OtherTrampoline.audio.Play();
            }
            else
            {
                //OtherPlayer.GetComponent<Collider>().enabled = false; 
                if(canPlayMusic)
                {
                    canPlayMusic = false; 
                    fallSoundController.audio.Play();
                }
            }
        }
	}
}
