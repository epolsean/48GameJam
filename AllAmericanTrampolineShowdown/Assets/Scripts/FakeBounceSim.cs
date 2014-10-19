using UnityEngine;
using System.Collections;

public class FakeBounceSim : MonoBehaviour {

    public GameObject Player;
    public GameObject OtherPlayer;
    public int PlayerBounceSpeed = 14;
    public int OtherPlayerBounceSpeed = 14;
    public bool isPlayerFattist = false;
    public bool isOtherFattist = false; 


    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Player.transform.position.y <= 1.5)
        {
            print("Player UP");
            //Player.GetComponent<CharacterController>().velocity.Equals(Vector3.up * BounceSpeed);
            if (!isPlayerFattist)
            {
                Player.rigidbody.velocity = transform.TransformDirection(Vector3.up * PlayerBounceSpeed);
            }
            else
            {
                Player.GetComponent<Collider>().enabled = false; 
            }
        }
        if(OtherPlayer.transform.position.y <= 1.5)
        {
            print("Other Player UP");
            //OtherPlayer.GetComponent<CharacterController>().velocity.Equals(Vector3.up * BounceSpeed);
            if (!isOtherFattist)
            {
                OtherPlayer.rigidbody.velocity = transform.TransformDirection(Vector3.up * OtherPlayerBounceSpeed);
            }
            else
            {
                OtherPlayer.GetComponent<Collider>().enabled = false; 
            }
        }
	}
}
