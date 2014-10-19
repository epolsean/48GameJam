using UnityEngine;
using System.Collections;

public class FPBS : MonoBehaviour {

    public Rigidbody Burger2Throw;

    public Rigidbody datBurger;
    public Rigidbody demFries;
    public Rigidbody datDrink;
    public Rigidbody FlameBurg;
    public Rigidbody TripBurg;

    public bool hasTripBurg = false;
    public bool hasFlameBurg = false;
    public int power3 = 0;
    float powerUpTimer = 5.0f;

    public int BurgerSpeed = 20;
    public bool CanFire = true;
    public int IntBurg;
    public Animator playerAnim;
    public GameObject player01;

    // Use this for initialization
	void Start () {
        player01 = GameObject.Find("Player01");
        playerAnim = player01.GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetMouseButtonDown(0) || Input.GetButtonUp("Fire1"))
        {
            if(CanFire)
            {
                CanFire = false;
                player01.GetComponentInChildren<PlayerAnimationControllerV2>().AnimObj.SetTrigger("Throw");
                IntBurg = Random.Range(0, 3);
                if(IntBurg >= 2)
                {
                    Burger2Throw = demFries;
                }
                else if(IntBurg >= 1)
                {
                    Burger2Throw = datDrink;
                }
                else
                {
                    Burger2Throw = datBurger;
                }

                if (hasFlameBurg)
                {
                    Burger2Throw = FlameBurg;
                }
                else if (hasTripBurg)
                {
                    Burger2Throw = TripBurg;
                }
                Invoke("ThrowBurger", 0.8f);
            }
        }
        if (hasFlameBurg || hasTripBurg)
        {
            powerUpTimer -= Time.deltaTime;
        }
        if (powerUpTimer <= 0)
        {
            hasTripBurg = false;
            hasFlameBurg = false;
        }
	}

    void ResetFire()
    {
        CanFire = true;
    }

    public void ThrowBurger()
    {
        Rigidbody Burger = Instantiate(Burger2Throw, this.transform.position, this.transform.rotation) as Rigidbody;
        if (this.gameObject.tag == "Player")
        {
            Burger.gameObject.tag = "Player1Bullet";
        }
        else if (this.gameObject.tag == "Player02")
        {
            Burger.gameObject.tag = "Player2Bullet";
        }
        Burger.velocity = transform.TransformDirection(Vector3.forward * BurgerSpeed);
        //Burger.AddForce(Vector3.forward * BurgerSpeed);
        
        Destroy(Burger.gameObject, 2);
        audio.Play();
        if (power3 > 0)
        {
            Invoke("ResetFire", 0.5f);
            power3--;
        }
        else
        {
            Invoke("ResetFire", 1);
        }
    }
}
