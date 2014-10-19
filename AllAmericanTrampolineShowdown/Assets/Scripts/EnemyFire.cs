using UnityEngine;
using System.Collections;

public class EnemyFire : MonoBehaviour {

    public Rigidbody Burger2Throw;

    public Rigidbody datBurger;
    public Rigidbody demFries;
    public Rigidbody datDrink;
    public Rigidbody FlameBurg;
    public Rigidbody TripBurg;

    public int IntBurg;
    public int Speed = 20;
    public double shootTimer;
    public bool FIRE = false; 
    // Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        shootTimer += Time.deltaTime;
        if(shootTimer >= 2 && FIRE)
        {
            Invoke("ThrowBurger", 0.7f);
            shootTimer = 0;
            FIRE = false;
            print("FIRE OFF");
        }
	}
    public void ThrowBurger()
    {
        IntBurg = Random.Range(0, 3);
        if (IntBurg >= 2)
        {
            Burger2Throw = demFries;
        }
        else if (IntBurg >= 1)
        {
            Burger2Throw = datDrink;
        }
        else
        {
            Burger2Throw = datBurger;
        } 
        Rigidbody Burger = Instantiate(Burger2Throw, this.transform.position, this.transform.rotation) as Rigidbody;
        Burger.velocity = transform.TransformDirection(Vector3.forward * Speed);
        //Burger.AddForce(Vector3.forward * BurgerSpeed);
        Destroy(Burger.gameObject, 2);
        audio.Play();
    }
}
