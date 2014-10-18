using UnityEngine;
using System.Collections;

public class FakeBounceSim : MonoBehaviour {

    public GameObject Player;
    public GameObject OtherPlayer;
    public int PlayerBounceSpeed = 11;
    public int OtherPlayerBounceSpeed = 11;

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Player.transform.position.y <= 1.5)
        {
            print("Player UP");
            //Player.GetComponent<CharacterController>().velocity.Equals(Vector3.up * BounceSpeed);
            Player.rigidbody.velocity = transform.TransformDirection(Vector3.up * PlayerBounceSpeed);
        }
        if(OtherPlayer.transform.position.y <= 1.5)
        {
            print("Other Player UP");
            //OtherPlayer.GetComponent<CharacterController>().velocity.Equals(Vector3.up * BounceSpeed);
            OtherPlayer.rigidbody.velocity = transform.TransformDirection(Vector3.up * OtherPlayerBounceSpeed);
        }
	}
}
