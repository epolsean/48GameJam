using UnityEngine;
using System.Collections;

public class TutorialBounce : MonoBehaviour {

    public GameObject Player;
    public int PlayerBounceSpeed = 14;

    public int Player1MaxHeight = 15;
    public int Player1MinHeight = 8;

    public bool isPlayerFattist = false;
    public bool canPlayMusic = true; 

    public GameObject PlayerTrampoline;


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
                if (Input.GetAxis("Vertical") == 1)
                {
                    if (PlayerBounceSpeed < Player1MaxHeight)
                    {
                        PlayerBounceSpeed++;
                    }
                }
                else if (Input.GetAxis("Vertical") == -1)
                {
                    if (PlayerBounceSpeed > Player1MinHeight)
                    {
                        PlayerBounceSpeed--;
                    }
                }
                PlayerTrampoline.GetComponent<TestTramp>().TrampAnim.SetBool("CanBounce", true);
                Player.rigidbody.velocity = transform.TransformDirection(Vector3.up * PlayerBounceSpeed);
            }
        }
	}
}
