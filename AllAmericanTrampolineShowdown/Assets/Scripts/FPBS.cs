using UnityEngine;
using System.Collections;

public class FPBS : MonoBehaviour {

    public Rigidbody datBurger;
    public int BurgerSpeed = 20;
    public bool CanFire = true; 

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetMouseButtonDown(0))
        {
            if(CanFire)
            {
                CanFire = false; 
                Rigidbody Burger = Instantiate(datBurger, this.transform.position, this.transform.rotation) as Rigidbody;
                Burger.velocity = transform.TransformDirection(Vector3.forward * BurgerSpeed);
                //Burger.AddForce(Vector3.forward * BurgerSpeed);
                Destroy(Burger.gameObject, 2);
                audio.Play();
                Invoke("ResetFire", 1);
            }
        }
	}

    void ResetFire()
    {
        CanFire = true;
    }
}
