using UnityEngine;
using System.Collections;

public class EnemyFire : MonoBehaviour {

    public Rigidbody enemyBurger;
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
            ThrowBurger();
            shootTimer = 0;
            FIRE = false;
            print("FIRE OFF");
        }
	}
    public void ThrowBurger()
    {
        Rigidbody Burger = Instantiate(enemyBurger, this.transform.position, this.transform.rotation) as Rigidbody;
        Burger.velocity = transform.TransformDirection(Vector3.forward * Speed);
        //Burger.AddForce(Vector3.forward * BurgerSpeed);
        Destroy(Burger.gameObject, 2);
        audio.Play();
    }
}
